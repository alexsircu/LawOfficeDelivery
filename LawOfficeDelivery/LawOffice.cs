using LawOfficeDelivery.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LawOfficeDelivery.Interface;

namespace LawOfficeDelivery
{
    internal class LawOffice
    {
        OfficeManager _officeManager;
        TranslationOffice _translationOffice;
        FoodDeliveryOffice _foodDeliveryOffice;
        FoodProvider _foodProvider;
        TranslationProvider _translationProvider;

        public OfficeManager OfficeManagerProp { get => _officeManager; set => _officeManager = value; }
        public TranslationOffice TranslationOfficeProp { get => _translationOffice; set => _translationOffice = value; }
        public FoodDeliveryOffice FoodDeliveryOfficeProp { get => _foodDeliveryOffice; set => _foodDeliveryOffice = value; }
        public FoodProvider FoodProvider { get => _foodProvider; set => _foodProvider = value; }
        public TranslationProvider TranslationProvider { get => _translationProvider; set => _translationProvider = value; }

        public LawOffice(FoodProvider foodProvider, TranslationProvider translationProvider) 
        {
            OfficeManagerProp = new OfficeManager();
            TranslationOfficeProp = new TranslationOffice();
            FoodDeliveryOfficeProp = new FoodDeliveryOffice();
            AddFoodProvider(foodProvider);
            AddTranslationProvider(translationProvider);
        }

        private void AddFoodProvider(FoodProvider foodProvider)
        {
            if (foodProvider is null) return;
            FoodProvider = foodProvider;
        }

        private void AddTranslationProvider(TranslationProvider translationProvider)
        {
            if (translationProvider is null) return;
            TranslationProvider = translationProvider;
        }

        internal class OfficeManager : Person, IOrderOfficeFactory
        {
            LawOffice _office;

            public LawOffice Office { get => _office; set => _office = value; }

            public IOrderDeliveryFactory GetOrderOffice(char letter)
            {
                if (letter == 'T') return Office.TranslationOfficeProp;
                if (letter == 'C') return Office.FoodDeliveryOfficeProp;
                return null;
            }
        }

        internal class TranslationOffice : IOrderDeliveryFactory
        {

        }

        internal class FoodDeliveryOffice : IOrderDeliveryFactory
        {

        }
    }
}
