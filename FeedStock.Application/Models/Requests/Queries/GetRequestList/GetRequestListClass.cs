using AutoMapper;
using FeedStock.Application.Common.Mappings;
using FeedStock.Domain.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedStock.Application.Models.Requests.Queries.GetRequestList
{
    public class GetRequestListClass: IMapWith<Request>
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string State { get; set; }
        public bool Paper { get; set; }
        public bool Carton { get; set; }
        public bool Poddon { get; set; }
        public string Address { get; set; }
        public string CreatedData { get; set; }
        public string TakenData { get; set; }
        public string WeightedData { get; set; }
        public string FinishedData { get; set; }
        public float TotalPrice { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Request, GetRequestListClass>()
                .ForMember(requestVM => requestVM.Id, x => x.MapFrom(req => req.Id))
                .ForMember(requestVM => requestVM.Description, x => x.MapFrom(req => req.Description))
                .ForMember(requestVM => requestVM.State, x => x.MapFrom(req => RuState(req.State)))
                .ForMember(requestVM => requestVM.Address, x => x.MapFrom(req => req.Address))
                .ForMember(requestVM => requestVM.CreatedData, x => x.MapFrom(req => DateFormat(req.Data)))
                .ForMember(requestVM => requestVM.TakenData, x => x.MapFrom(req => DateFormat(req.TakenData)))
                .ForMember(requestVM => requestVM.WeightedData, x => x.MapFrom(req => DateFormat(req.WeightData)))
                .ForMember(requestVM => requestVM.FinishedData, x => x.MapFrom(req => DateFormat(req.FinishedData)))
                .ForMember(requestVM => requestVM.Paper, x => x.MapFrom(req => CheckMaterial(req.Materials, "Пленка")))
                .ForMember(requestVM => requestVM.Carton, x => x.MapFrom(req => CheckMaterial(req.Materials, "Картон")))
                .ForMember(requestVM => requestVM.Poddon, x => x.MapFrom(req => CheckMaterial(req.Materials, "Поддоны")));


        }

        public string RuState(string data)
        {
            var res = string.Empty;
            switch (data)
            {
                case "created":
                    res = "Создан";
                    break;
                case "actual":
                    res = "Вывезен";
                    break;
                case "weighted":
                    res = "Взвешен";
                    break;
                case "finished":
                    res = "Завершен";
                    break;
            }
            return res;
        }

        public string DateFormat(string data)
        {
            if (data != null)
            {
                return StrToDate(data.Replace('/', '.'));
            }
            else
            {
                return "-";
            }
        }

        public string StrToDate(string val)
        {
            CultureInfo enUS = new CultureInfo("ru-RU");
            DateTime dateValue;
            if (DateTime.TryParseExact(val, "dd.MM.yyyy", enUS,
                                       DateTimeStyles.AllowWhiteSpaces, out dateValue))
            {
                return dateValue.ToString("dd.MM.yy");
            }
            else
            {
                return null;
            }
        }

        public bool CheckMaterial(string data, string pattern)
        {
            bool res = false;
            var _separatedData = data.Split(':', ';');
            foreach (var x in _separatedData)
            {
                if (x == pattern)
                {
                    res = true;
                    break;
                }
            }
            return res;
        }

        //public float PriceValidator(string price, string material)
        //{
        //    if (price != null)
        //    {
        //        return float.Parse(price);
        //    }
        //    else
        //    {
        //        return  CountPrice(CheckMaterialAmount(material, 5), CheckMaterialAmount(material, 1), CheckMaterialAmount(material, 3));
        //    }
        //}

        //public string CountPrice(string poddonAmount, string plenkaAmount, string cartonAmount)
        //{
        //    var _currentPrice = _context.Prices.FirstOrDefault();
        //    float _plenkaPrice = (float.Parse(_currentPrice.Plenka) * float.Parse(Validator(plenkaAmount)));
        //    float _poddonPrice = (float.Parse(_currentPrice.Poddon) * float.Parse(Validator(poddonAmount)));
        //    float _cartonPrice = (float.Parse(_currentPrice.Carton) * float.Parse(Validator(cartonAmount)));
        //    return (_plenkaPrice + _cartonPrice + _poddonPrice).ToString();

        //}

        public string Validator(string data)
        {
            if (string.IsNullOrEmpty(data))
            {
                return "0";
            }
            else
            {
                return data;
            }
        }

        public string CheckMaterialAmount(string data, int index)
        {
            var res = string.Empty;
            var _separatedData = data.Split(':', ';');
            if (_separatedData.Count() == 7)
            {
                res = _separatedData[index];
            }
            return res;
        }
    }
}
