﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BraintreeHttp;
using Microsoft.AspNetCore.Mvc;
using MyShopK6.Models;
using PayPal.Core;
using PayPal.v1.Payments;
using MyShopK6.Helper;

namespace MyShopK6.Controllers
{
    public class PaypalController : Controller
    {
		public IActionResult Index()
        {
            return View();
        }

        public List<CartItem> Cart
        {
            get
            {
                var data = HttpContext.Session.GetObject<List<CartItem>>("GioHang");
                if (data == null)
                {
                    data = new List<CartItem>();
                }

                return data;
            }
        }
        public async Task<IActionResult> Checkout()
        {
            //SandboxEnvironment(clientId, clientSerect)
            var environment = new SandboxEnvironment("AX_kJNjRRJ3-EatrprZEudFpqOHcD22CFJiyilo0usKgEKuQsQ7pih2JQuSgxoKlAEi8N6Z031s8udSf", "EFqNIdiiBAK2Gg3sQk7kkt3L4NbckK7AxsLRuzF0dikFSwoayxHSdfyb0PqC5SiJIN10l7utfd87sE9w");
            var client = new PayPalHttpClient(environment);

            //Đọc thông tin đơn hàng từ Session
            var itemList = new ItemList()
            {
                Items = new List<Item>()
            };

            var tongTien = Cart.Sum(p => p.ThanhTien);
			foreach (var item in Cart)
			{
				itemList.Items.Add(new Item()
				{
					Name = item.HangHoa.TenHh,
					Currency = "USD",
					Price = item.HangHoa.GiaBan.ToString(),
					Quantity = item.SoLuong.ToString(),
					Sku = "sku",
					Tax = "0"
				});

				//itemList.Items.Add(new Item()
				//{
				//	Name = "Coca",
				//	Currency = "USD",
				//	Price = "5",
				//	Quantity = "1",
				//	Sku = "sku",
				//	Tax = "0"
				//});
				//itemList.Items.Add(new Item()
				//{
				//	Name = "Pepsi",
				//	Currency = "USD",
				//	Price = "2",
				//	Quantity = "3",
				//	Sku = "sku",
				//	Tax = "0"
				//});
			}
			var payment = new Payment()
            {
                Intent = "sale",
                Transactions = new List<Transaction>()
                {
                    new Transaction()
                    {
                        Amount = new Amount()
                        {
                            Total = tongTien.ToString(),
                            Currency = "USD",
                            Details = new AmountDetails
                            {
                                Tax = "0",
                                Shipping = "0",
                                Subtotal = tongTien.ToString()
                            }
                        },
                        ItemList = itemList,
                        Description = "Don hang 001",
                        InvoiceNumber = DateTime.Now.Ticks.ToString()
                    }
                },
                RedirectUrls = new RedirectUrls()
                {
                    CancelUrl = "http://localhost:53845/Paypal/Fail",
                    ReturnUrl = "http://localhost:53845/Paypal/Success"
				},
                Payer = new Payer()
                {
                    PaymentMethod = "paypal"
                }
            };

            PaymentCreateRequest request = new PaymentCreateRequest();
            request.RequestBody(payment);

            try
            {
                HttpResponse response = await client.Execute(request);
                var statusCode = response.StatusCode;
                Payment result = response.Result<Payment>();

                var links = result.Links.GetEnumerator();
                string paypalRedirectUrl = null;
                while (links.MoveNext())
                {
                    LinkDescriptionObject lnk = links.Current;
                    if (lnk.Rel.ToLower().Trim().Equals("approval_url"))
                    {
                        //saving the payapalredirect URL to which user will be redirected for payment  
                        paypalRedirectUrl = lnk.Href;
                    }
                }

                return Redirect(paypalRedirectUrl);

            }
            catch (HttpException httpException)
            {
                var statusCode = httpException.StatusCode;
                var debugId = httpException.Headers.GetValues("PayPal-Debug-Id").FirstOrDefault();

                return RedirectToAction("Fail");
            }

            return View();
        }

        public IActionResult Success()
        {
            //Tạo đơn hàng trong CSDL với trạng thái : Đã thanh toán, phương thức: Paypal
            return Content("Thanh toán thành công");
        }

        public IActionResult Fail()
        {
            //Tạo đơn hàng trong CSDL với trạng thái : Chưa thanh toán, phương thức: 
            return Content("Thanh toán thất bại");
        }
    }
}