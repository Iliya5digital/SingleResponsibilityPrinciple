using System;
using System.Drawing;

namespace SingleResponsibilityPrinciple
{
    //служебный класс
    //нарушение принципа Single Responsibility Principle
    public static class Service
    {
        //вернуть изображение
        public static Image GetImage(string path)
        {
            throw new NotImplementedException();
        }

        //сохранить изображение
        public static void SaveImage(Image img)
        {
            //
        }

        //отправить email
        public static void SendEmailMessage(string address, string subject, string text)
        {
            //
        }

        //сгенерировать новый файл sitemap.xml
        public static void GenerateSiteMapFile(string[] values)
        {
            //
        }


    }
}
