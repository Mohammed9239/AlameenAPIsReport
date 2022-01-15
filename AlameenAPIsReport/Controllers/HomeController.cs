using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AlameenAPIsReport.Models;
using AlameenAPIsReport.ViewModels;
using ameen.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace AlameenAPIsReport.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly AmeenContext _context;
        private IConfiguration Configuration;

        public HomeController(AmeenContext context, IConfiguration _configuration)
        {
            _context = context;
            Configuration = _configuration;
        }


        // To Insert Server Name And Check Is Found Or Not
        [HttpPost("CheckServerName")]
        public IActionResult CheckServerName(string Server)
        {
            List<string> Name = new List<string>();
            SqlConnection con = new SqlConnection(String.Format(@"Server={0};Trusted_Connection=True;MultipleActiveResultSets=true", Server));
            try
            {
                con.Open();
                string q = @"select name from sys.sysdatabases";
                SqlCommand cmd = new SqlCommand(q, con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Name.Add(dr["name"].ToString());
                }

                return Ok(Name);
            }

            catch
            {
                return NotFound();
            }

            finally
            {
                con.Close();
            }
        }


        // To Connection With Server And Database
        [HttpPost("Connection")]
        public string Connection(string Server, string DatabaseName)
        {
            if (!String.IsNullOrEmpty(Server) && !String.IsNullOrEmpty(DatabaseName))
            {
                Configuration["ConnectionStrings:DefaultConnection"] = String.Format("Server={0};Database={1};Trusted_Connection=True;MultipleActiveResultSets=true", Server, DatabaseName);
                RedirectToAction("index");
            }

            string c = Configuration["ConnectionStrings:DefaultConnection"];
            return c;
        }


        // To Connection With Server And Database
        //[HttpPost("Connection")]
        //public string Login(string UserName, string Password)
        //{
        //    if (!String.IsNullOrEmpty(UserName) && !String.IsNullOrEmpty(Password))
        //    {
        //        Configuration["ConnectionStrings:DefaultConnection"] = String.Format("Server={0};Database={1};Trusted_Connection=True;MultipleActiveResultSets=true", Server, DatabaseName);
        //        RedirectToAction("index");
        //    }


        //}

        /// <summary>
        /// ACCOUNTS
        /// </summary>
        /// <returns></returns>


        // To Check UserName And Password
        [HttpPost("Login")]
        public IActionResult Login(string user, string password)
        {
            var Ac = _context.Myuser000.Where(a => a.UserName == user && a.Password == password).FirstOrDefault();
            return Ok(Ac);
        }


        // To Get Parent Level From Ac000
        [HttpGet("GetAcLev0")]
        public JsonResult GetAcLev0()
        {
            var Ac = _context.Ac000.Where(a => a.ParentGuid == new Guid("00000000-0000-0000-0000-000000000000")).ToList();
            return new JsonResult(Ac);
        }


        // To Get Sub Level From Ac000
        [HttpGet("GetAcSub")]
        public JsonResult GetAcSub(Guid id)
        {
            var Ac = _context.Ac000.Where(a => a.ParentGuid == id).Select(a => new AcSub {
                Guid = a.Guid,
                Name = a.Name,
                islast = false,
            }).ToList();

            foreach (var item in Ac)
            {
                if (_context.Ac000.Where(a => a.ParentGuid == item.Guid).ToList().Count == 0)
                {
                    item.islast = true;
                }
            }

     
            return new JsonResult(Ac);
        }


        // To Get Ac Name by Search
        [HttpGet("Search")]
        public JsonResult Search(string word)
        {
            var Ac = _context.Ac000.Where(a => a.Name.Contains(word)).ToList();
            return new JsonResult(Ac);
        }


        // To Get Ac Detalis
        [HttpGet("Details")]
        public async Task<JsonResult> Details(Guid id)
        {
            var Ac = await _context.Ac000.Select(a => new AcDetails
            {
                ID = a.Guid,
                AcName = _context.Ac000.Where(i => i.Guid == id).FirstOrDefault().Name,
                Currency = _context.My000.Where(i => i.Guid == a.CurrencyGuid).FirstOrDefault().Name,
                AcParent = _context.Ac000.Where(i => i.Guid == a.ParentGuid).FirstOrDefault().Name,
                AcFinally = _context.Ac000.Where(i => i.Guid == a.FinalGuid).FirstOrDefault().Name,
                Credit = a.Credit.Value,
                Debit = a.Debit.Value,
                Balance = a.Credit.Value - a.Debit.Value,
                BalanceText = "",

            }).FirstOrDefaultAsync(i => i.ID == id);

            ConvertNumbersToArabicAlphabet c = new ConvertNumbersToArabicAlphabet(((int)Ac.Balance).ToString(), Ac.Currency);
            Ac.BalanceText = c.GetNumberAr();

            return new JsonResult(Ac);
        }


        // To Select Currency Filtter
        [HttpGet("GetCurrency")]
        public JsonResult GetCurrency()
        {
            var Currency = _context.My000.Select(i => new { i.Guid, i.Name }).ToList();
            return new JsonResult(Currency);
        }


        // To Select دفتر الاستاذ الحسابات
        [HttpGet("Report")]
        public async Task<JsonResult> Report(Guid id, DateTime first, DateTime end, Guid? Currency)
        {
            if (!Currency.HasValue || Currency == Guid.Empty)
                Currency = _context.My000.FirstOrDefaultAsync(i => i.CurrencyVal == 1).Result.Guid;
            var CurrencyVal = _context.Mh000.OrderByDescending(i => i.Date).FirstOrDefaultAsync(i => i.CurrencyGuid == Currency).Result.CurrencyVal;

            if (CurrencyVal == null)
                CurrencyVal = _context.My000.FirstOrDefaultAsync(i => i.Guid == Currency).Result.CurrencyVal;

            var Ac = await _context.En000.Where(i => i.AccountGuid == id && i.Date.Value.Date >= first.Date && i.Date.Value.Date <= end.Date /*&& i.CurrencyGuid == Currency*/).Select(a => new EnDetails
            {
                AccountName = _context.Ac000.FirstOrDefault(i => i.Guid == a.AccountGuid).Name,
                CurrencyName = _context.My000.FirstOrDefault(i => i.Guid == a.CurrencyGuid).Name,
                Date = a.Date.Value.Date,
                snd = _context.Bt000.Where(I => I.Guid == _context.Bu000.Where(i => i.Guid == _context.Er000.Where(i => i.EntryGuid == a.ParentGuid).FirstOrDefault().ParentGuid).FirstOrDefault().TypeGuid).FirstOrDefault().Name + "  " + _context.Bu000.Where(i => i.Guid == _context.Er000.Where(i => i.EntryGuid == a.ParentGuid).FirstOrDefault().ParentGuid).FirstOrDefault().Number,
                snd1 = _context.Et000.Where(I => I.Guid == _context.Py000.Where(i => i.Guid == _context.Er000.Where(i => i.EntryGuid == a.ParentGuid).FirstOrDefault().ParentGuid).FirstOrDefault().TypeGuid).FirstOrDefault().Name + "  " + _context.Py000.Where(i => i.Guid == _context.Er000.Where(i => i.EntryGuid == a.ParentGuid).FirstOrDefault().ParentGuid).FirstOrDefault().Number,
                Debit = a.Debit / CurrencyVal,
                Credit = a.Credit / CurrencyVal,
                Balance = 0,
                Note = a.Notes,
                DebitTotal = 0,
                CreditTotal = 0,
            }).ToListAsync();

            double? totla = 0;
            double? DebitTotal = 0;
            double? CreditTotal = 0;

            foreach (var item in Ac)
            {
                totla = totla + (item.Debit - item.Credit);
                item.Balance = totla;

                DebitTotal += item.Debit;
                item.DebitTotal = DebitTotal;

                CreditTotal += item.Credit;
                item.CreditTotal = CreditTotal;
            }

            return new JsonResult(Ac);
        }



        /// <summary>
        ///  CUSTOMERS
        /// </summary>
        /// <returns></returns>

        // To Get Customer 
        [HttpGet("GetCustomer")]
        public JsonResult GetCustomer()
        {
            var Cu = _context.Cu000.Select(c => new
            {
                Guid = c.Guid,
                CustomerName = c.CustomerName,
                Balance = c.Credit - c.Debit,
                Currency = _context.My000.FirstOrDefault(i => i.Guid == _context.Ac000.FirstOrDefault(a => a.Guid == c.AccountGuid).CurrencyGuid).Code,
                AccountGuid = c.AccountGuid,
                Phone1 = c.Phone1,
                Phone2 = c.Phone2,
                Email = c.Email,
                Website = c.HomePage,
            });
            return new JsonResult(Cu);
        }


        // To Get Customer Details
        [HttpGet("CustomerDetails")]
        public JsonResult CustomerDetails(Guid id)
        {
            var Cu = _context.Cu000.Select(c => new
            {
                Guid = c.Guid,
                AccountGuid = c.AccountGuid,
                CustomerName = c.CustomerName,
                Phone1 = c.Phone1,
                Phone2 = c.Phone2,
                Email = c.Email,
                Website = c.HomePage,

            }).FirstOrDefault(i => i.Guid == id);
            return new JsonResult(Cu);
        }


        // To Get Customer دفتر الاستاذ  // id = AccountGuid
        [HttpGet("CustomerReport")]
        public async Task<JsonResult> CustomerReport(Guid id, DateTime first, DateTime end, Guid? Currency)
        {
            if (!Currency.HasValue || Currency == Guid.Empty)
                Currency = _context.My000.FirstOrDefaultAsync(i => i.CurrencyVal == 1).Result.Guid;
            var CurrencyVal =  _context.Mh000.OrderByDescending(i => i.Date).FirstOrDefaultAsync(i => i.CurrencyGuid == Currency).Result.CurrencyVal;

            if (CurrencyVal == null)
                CurrencyVal =  _context.My000.FirstOrDefaultAsync(i => i.Guid == Currency).Result.CurrencyVal;

            var Cu = await _context.En000.Where(i => i.AccountGuid == id && i.Date.Value.Date >= first.Date && i.Date.Value.Date <= end.Date /*&& i.CurrencyGuid == Currency*/).Select(a => new EnDetails
            {
                CustomerName = _context.Ac000.FirstOrDefault(i => i.Guid == a.AccountGuid).Name,
                AccountName = _context.Ac000.FirstOrDefault(i => i.Guid == a.AccountGuid).Name + " " + _context.Ac000.FirstOrDefault(i => i.Guid == a.AccountGuid).Number,
                CurrencyName = _context.My000.FirstOrDefault(i => i.Guid == a.CurrencyGuid).Name,
                Date = a.Date.Value,
                snd = _context.Bt000.Where(I => I.Guid == _context.Bu000.Where(i => i.Guid == _context.Er000.Where(i => i.EntryGuid == a.ParentGuid).FirstOrDefault().ParentGuid).FirstOrDefault().TypeGuid).FirstOrDefault().Name + "  " + _context.Bu000.Where(i => i.Guid == _context.Er000.Where(i => i.EntryGuid == a.ParentGuid).FirstOrDefault().ParentGuid).FirstOrDefault().Number,
                snd1 = _context.Et000.Where(I => I.Guid == _context.Py000.Where(i => i.Guid == _context.Er000.Where(i => i.EntryGuid == a.ParentGuid).FirstOrDefault().ParentGuid).FirstOrDefault().TypeGuid).FirstOrDefault().Name + "  " + _context.Py000.Where(i => i.Guid == _context.Er000.Where(i => i.EntryGuid == a.ParentGuid).FirstOrDefault().ParentGuid).FirstOrDefault().Number,
                Debit = a.Debit / CurrencyVal,
                Credit = a.Credit / CurrencyVal,
                Balance = 0,
                Note = a.Notes,
                DebitTotal = 0,
                CreditTotal = 0,
            }).ToListAsync();

            double? totla = 0;
            double? DebitTotal = 0;
            double? CreditTotal = 0;

            foreach (var item in Cu)
            {
                totla = totla + (item.Debit - item.Credit);
                item.Balance = totla;

                DebitTotal += item.Debit;
                item.DebitTotal = DebitTotal;

                CreditTotal += item.Credit;
                item.CreditTotal = CreditTotal;
            }

            return new JsonResult(Cu);
        }


        // To Get Customer  كشف حساب  // id = AccountGuid
        [HttpGet("CustomerAccountReport")]
        public async Task<JsonResult> CustomerAccountReport(Guid id, DateTime first, DateTime end, Guid? Currency)
        {
            if (!Currency.HasValue || Currency == Guid.Empty)
                Currency = _context.My000.FirstOrDefaultAsync(i => i.CurrencyVal == 1).Result.Guid;
            var CurrencyVal = _context.Mh000.OrderByDescending(i => i.Date).FirstOrDefaultAsync(i => i.CurrencyGuid == Currency).Result.CurrencyVal;

            if (CurrencyVal == null)
                CurrencyVal = _context.My000.FirstOrDefaultAsync(i => i.Guid == Currency).Result.CurrencyVal;

            var Cu = await _context.En000.Where(i => i.AccountGuid == id && i.Date.Value.Date >= first.Date && i.Date.Value.Date <= end.Date /*&& i.CurrencyGuid == Currency*/).Select(a => new EnDetails
            {
                ID = a.Guid,
                CustomerName = _context.Ac000.FirstOrDefault(i => i.Guid == a.AccountGuid).Name,
                AccountName = _context.Ac000.FirstOrDefault(i => i.Guid == a.AccountGuid).Name + " " + _context.Ac000.FirstOrDefault(i => i.Guid == a.AccountGuid).Number,
                CurrencyName = _context.My000.FirstOrDefault(i => i.Guid == a.CurrencyGuid).Name,
                Date = a.Date.Value,
                snd = _context.Bt000.Where(I => I.Guid == _context.Bu000.Where(i => i.Guid == _context.Er000.Where(i => i.EntryGuid == a.ParentGuid).FirstOrDefault().ParentGuid).FirstOrDefault().TypeGuid).FirstOrDefault().Name + "  " + _context.Bu000.Where(i => i.Guid == _context.Er000.Where(i => i.EntryGuid == a.ParentGuid).FirstOrDefault().ParentGuid).FirstOrDefault().Number,
                snd1 = _context.Et000.Where(I => I.Guid == _context.Py000.Where(i => i.Guid == _context.Er000.Where(i => i.EntryGuid == a.ParentGuid).FirstOrDefault().ParentGuid).FirstOrDefault().TypeGuid).FirstOrDefault().Name + "  " + _context.Py000.Where(i => i.Guid == _context.Er000.Where(i => i.EntryGuid == a.ParentGuid).FirstOrDefault().ParentGuid).FirstOrDefault().Number,
                Debit = a.Debit / CurrencyVal,
                Credit = a.Credit / CurrencyVal,
                Balance = 0,
                Note = a.Notes,
                DebitTotal = 0,
                CreditTotal = 0,
                hasbi = _context.Bi000.Where(b => b.ParentGuid == _context.Bu000.Where(i => i.Guid == _context.Er000.Where(e => e.EntryGuid == a.ParentGuid).FirstOrDefault().ParentGuid).FirstOrDefault().Guid).FirstOrDefault().Guid,
                BiDetalis = _context.Bi000.Where(b => b.ParentGuid == _context.Bu000.Where(i => i.Guid == _context.Er000.Where(e => e.EntryGuid == a.ParentGuid).FirstOrDefault().ParentGuid).FirstOrDefault().Guid).Select(e => new BiDetalis
                {
                    MtId = e.MatGuid,
                    Note = _context.Mt000.FirstOrDefault(i => i.Guid == _context.Bi000.Where(b => b.ParentGuid == _context.Bu000.Where(i => i.Guid == _context.Er000.Where(e => e.EntryGuid == a.ParentGuid).FirstOrDefault().ParentGuid).FirstOrDefault().Guid).FirstOrDefault().MatGuid).Name,
                    Unit = e.Unity,
                    Price = e.Price,
                }).ToList(),

            }).ToListAsync();

            double? totla = 0;
            double? DebitTotal = 0;
            double? CreditTotal = 0;

            foreach (var item in Cu)
            {
                totla = totla + (item.Debit - item.Credit);
                item.Balance = totla;

                DebitTotal += item.Debit;
                item.DebitTotal = DebitTotal;

                CreditTotal += item.Credit;
                item.CreditTotal = CreditTotal;
            }

            foreach (var item in Cu)
            {
                if (item.BiDetalis.Count > 0)
                {
                    foreach (var p in item.BiDetalis)
                    {
                        switch (p.Unit)
                        {
                            case 1:
                                p.UnitV = _context.Mt000.FirstOrDefault(i => i.Guid == p.MtId).Unity;
                                p.QunV = _context.Bi000.FirstOrDefault(i => i.MatGuid == p.MtId).Qty;
                                break;
                            case 2:
                                p.UnitV = _context.Mt000.FirstOrDefault(i => i.Guid == p.MtId).Unit2;
                                p.QunV = _context.Bi000.FirstOrDefault(i => i.MatGuid == p.MtId).Qty2;
                                break;
                            case 3:
                                p.UnitV = _context.Mt000.FirstOrDefault(i => i.Guid == p.MtId).Unit3;
                                p.QunV = _context.Bi000.FirstOrDefault(i => i.MatGuid == p.MtId).Qty3;
                                break;
                            default:
                                break;
                        }
                    }
                }

            }

            return new JsonResult(Cu);
        }



        /// <summary>
        /// MATERALS
        /// </summary>
        /// <returns></returns>

        // To Get Mt Lev0 
        [HttpGet("GetMtLev0")]
        public JsonResult GetMtLev0()
        {
            var Mt = _context.Gr000.Where(i => i.ParentGuid == new Guid("00000000-0000-0000-0000-000000000000")).Select(c => new
            {
                Guid = c.Guid,
                Name = c.Name,

            }).ToList();
            return new JsonResult(Mt);
        }


        // To Get Mt Sub 
        [HttpGet("GetMtSub")]
        public JsonResult GetMtSub(Guid id)
        {
            var Gr = _context.Gr000.Where(i => i.ParentGuid == id).Select(c => new
            {
                Guid = c.Guid,
                Name = c.Name,

            }).ToList();

            if (Gr.Count > 0)
            {
                return new JsonResult(Gr);

            }

            else
            {
                var Mt = _context.Mt000.Where(i => i.GroupGuid == id).Select(c => new
                {
                    Guid = c.Guid,
                    Name = c.Name,

                }).ToList();

                return new JsonResult(Mt);
            }



        }


        // To Get Mt Name by Search
        [HttpGet("MtSearch")]
        public JsonResult MtSearch(string word)
        {
            var Mt = _context.Mt000.Where(a => a.Name.Contains(word)).Select(c => new {
                Guid = c.Guid,
                Name = c.Name,
                Number = c.Name,
            }).ToList();
            return new JsonResult(Mt);
        }


        // To Get Mt Detalis
        [HttpGet("MtDetails")]
        public JsonResult MtDetails(Guid id)
        {
            var bi = _context.Bi000.Where(i => i.MatGuid == id).ToList();
            List<En000> l = new List<En000>();
            foreach (var item in bi)
            {
                if (_context.En000.Any(i => i.BiGuid == item.Guid))
                {
                    l.Add(_context.En000.Where(i => i.BiGuid == item.Guid).FirstOrDefault());
                }
            }

            double? inm = 0;
            double? outm = 0;
            foreach (var item in l)
            {
                inm += item.Debit;
                outm += item.Credit;
            }

            //var enlist = (from EN in _context.En000
            //             join BI in _context.Bi000 on EN.BiGuid equals BI.Guid
            //             where BI.MatGuid == id
            //             select new
            //             {
            //                 EN.Debit,
            //                 EN.Credit
            //             }).ToList();

            //double? IN = 0;
            //double? OUT = 0;

            //foreach(var x in enlist)
            //{
            //    IN = x.Debit + IN;
            //    OUT = x.Credit + OUT;
            //}

            var Mt = _context.Mt000.Select(c => new MtDetails
            {
                ID = c.Guid,
                Name = c.Name,
                GroupName = _context.Gr000.FirstOrDefault(i => i.Guid == c.GroupGuid).Name,
                Type = c.Type,
                TypeName = "",
                Unit = c.Unity,
                Currency = _context.My000.FirstOrDefault(i => i.Guid == c.CurrencyGuid).Name,
                Quantity = c.Qty,
                Input = inm,
                Output = outm,
                Balance = inm - outm,

            }).FirstOrDefault(i => i.ID == id);

            switch (Mt.Type)
            {
                case 0:
                    Mt.TypeName = "مستودعية";
                    break;
                case 1:
                    Mt.TypeName = "خدمية";
                    break;
                case 2:
                    Mt.TypeName = "أصل ثابت";
                    break;
            }

            return new JsonResult(Mt);
        }


        // To Get Mt Depot
        [HttpGet("MtDepot")]
        public JsonResult MtDepot(Guid id)
        {
            var Mt = _context.Mt000.Select(c => new
            {
                ID = c.Guid,
                NameOfDepot = _context.St000.FirstOrDefault(i => i.Guid == _context.Ms000.FirstOrDefault(m => m.MatGuid == c.Guid).StoreGuid).Name,
                Unit = c.Unity,
                Quantity = c.Qty,

            }).FirstOrDefault(i => i.ID == id);

            return new JsonResult(Mt);
        }
    }
}