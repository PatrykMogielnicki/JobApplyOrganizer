using Application.Zadanie.Interface;
using Application.Zadanie.Model;
using Domain.Entities.Interfaces;
using System.Buffers.Text;

namespace Application.Zadanie.Mapping
{
    public class ZadanieParser : IZadanieParser
    {
        public string Parse(IZadanie zadanie)
        {
            return string.Format("{0},{1},{2},{3},{4},{5}", zadanie.Guid, zadanie.Name,((int)zadanie.Stan),zadanie.FileName,zadanie.Date.First(), Base64Encode(zadanie.Description));
        }

        public IZadanie Parse(IZadanie zadanie, ZadanieModel model)
        {
            zadanie.Name = model.Name;
            zadanie.Checked = model.Checked;
            zadanie.Color = model.Color;
            zadanie.Date = model.Date;
            zadanie.Description = model.Description;
            zadanie.Stan = model.Stan;
            zadanie.FileName = model.FileLink;
            return zadanie;
        }

        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }
    }
}
