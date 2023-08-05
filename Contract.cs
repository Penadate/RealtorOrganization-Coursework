using Aspose.Pdf;
using Aspose.Pdf.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Realtor
{
    internal class Contract
    {
        public void CooperationContract(string Customer, string Realtor, string Date)
        {
            Document document = new Document();

            // Добавить страницу
            Page page = document.Pages.Add();

            // Добавить текст на новую страницу
            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment($"Договір співпраці рієлтора та клієнта"));
            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment($"Клієнт {Customer} просить надати послуги рієлтора {Realtor}, для оформлення договору(ів) оренди комерційної нерухомості. Клієнт зобов'язується:"));
            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment($"1.1. Дослухатися до всіх порад рієлтора та виконувати всі вказівки"));
            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment($"1.2. Надати рієлторській організації доступ до копій документів встановлення особи клієнта та документів на власність комерційної нерухомості за потребою"));
            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment($"Рієлтор зобов'язується:"));
            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment($"2.1: Не повідомляти клієнтські дані третім особам"));
            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment($"2.2: Виконувати свої обов'язки та контролювати кожен єтап оренди комерційної нерухомості"));
            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment($"Рієлтор {Realtor}                      ____________"));
            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment($"Клієнт {Customer}                      ____________"));
            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment($"Дата: {Date}"));

            // Сохранить PDF 
            document.Save("contract.pdf");
        }

        public void RentalContract(string Landlord, string Tenant, string Realtor,string city, string address, string type, string term, string totalPrice, string date, string realtors_commision)
        {
            Document document = new Document();

            // Добавить страницу
            Page page = document.Pages.Add();

            int price = ((Convert.ToInt32(totalPrice)/Convert.ToInt32(term)) * Convert.ToInt32(realtors_commision))/100;
            // Добавить текст на новую страницу
            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment($"Договір оренди нерухомості"));
            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment($"Клієнт {Tenant} надає в оренду іншому клієнту {Landlord} власність типу {type} за адрессою м. {city} {address} на термін {term} місяців. Орендар зобов'язується:"));
            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment($"1. Сплатити загальну вартість оренди: {totalPrice} грн"));
            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment($"2. Виплатити рієлтору комісію у розмірі {price} грн, яка складає {realtors_commision}% від першого платежу."));
            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment($"Рієлтор {Realtor}                      ____________"));
            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment($"Орендодатор {Landlord}                      ____________"));
            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment($"Орендар {Tenant}                      ____________"));
            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment($"Дата: {date}"));

            // Сохранить PDF 
            document.Save("contract.pdf");
        }
    }
}
