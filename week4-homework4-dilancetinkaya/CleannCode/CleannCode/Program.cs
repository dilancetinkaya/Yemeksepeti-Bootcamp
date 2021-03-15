using System;
using System.Collections.Generic;

namespace CleannCode
{
    class Program
    {
        static void Main(string[] args)
        {

            #region BoolKarsilastirma
            bool control = true;
            if (control == true)
            {
                Console.WriteLine("bad ");
            }

            if (control)
            {
                Console.WriteLine("clean ");
            }


            #endregion BoolKarsilastirma

            #region BooleanDegerAtama

            int Ucret = 600;
            bool odemeIslemi1;
            if (Ucret > 500)
            {
                odemeIslemi1 = true;
            }
            else
            {
                odemeIslemi1 = false;
            }

            bool odemeIslemi2 = Ucret > 600;

            #endregion BooleanDegerAtama


            #region PozitifOlmak



            bool isNoValue = true;


            if (!isNoValue)
            {
                Console.WriteLine("negative");
            }

            bool isValue = true;
            if (isValue)
            {
                Console.WriteLine("pozitive");
            }
            #endregion PozitifOlmak

            #region TenaryIf

            bool code = true;
            int limit;
            if (code)
            {
                limit = 1;
            }
            else
            {
                limit = -1;
            }


            limit = code ? 1 : -1;

            #endregion TenaryIf
             #region StronglyType
            const string messageType = "sms";

            string messageType1;

            //if (messageType1=="sms")
            //{

            //}
            //if (messageType1==messageType)
            //{

            //}

            #endregion StronglyType
            #region basiBos
            int total = 20;
            if (total < 30)
            {

            }
            int max = 30;
            if (total < max)
            {

            }
            #endregion basiBos
            #region  sadelestir
            int maxx = 20, min = 10, pricee = 30;
            int totall = (maxx - min) / 2;
            //if (pricee-(maxx - min) / 2)
            //{

            //}
            //if (pricee-totall)
            //{

            //}
            #endregion sadelestir


            #region karmasa
            //List<string> product = new List<string>();

            //foreach (var product in products)
            //{
            //    if{ 
            //     //koullar

            //    }
            //} //return product;

            //linq kullanmımı
            //return product.Where=>kosullar
            #endregion karmasa
            #region degiskenler
            int sayi1 = 20;
            int sayi2 = 30;
            if (sayi1 < 30)
            {

            }
            if (sayi2 < 40)
            {

            }
            //bunu yerine
            int sayi3 = 20;

            if (sayi3 < 30)
            {

            }
            int sayi4 = 30;
            if (sayi4 < 50)
            {

            }


            #endregion deigkenler

            #region paremetreler
             void paracek(int hesapno, int bakiye, int tc,string email, int cep)
            {
               
            }
            void paracek2(int hesapno, int bakiye ,int tc)
            {

            }
            void iletişim(string email,int cep) { }
            #endregion paremetreler

            #region girinti
            //void kosul()
            //{

            //    if ()
            //    {
            //        if ()
            //        {
            //            if ()
            //            {
            //            }
            //        }
            //    }
            //}

            bool b1 = true;
                bool b2 = true;
            if (b1)
            {

            }
            #endregion girinti

        }

    }
}
