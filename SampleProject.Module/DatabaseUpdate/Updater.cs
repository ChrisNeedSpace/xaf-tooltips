using System;

using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Updating;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.BaseImpl;
using DevExpress.ExpressApp.Security;
using SampleProject.Module.BusinessObjects;

namespace SampleProject.Module.DatabaseUpdate
{
    public class Updater : ModuleUpdater
    {
        public Updater(IObjectSpace objectSpace, Version currentDBVersion) : base(objectSpace, currentDBVersion) { }
        public override void UpdateDatabaseAfterUpdateSchema()
        {
            base.UpdateDatabaseAfterUpdateSchema();

            Zadanie zad1 = AddZadanie("Zad.1", "To jest zadanie", DateTime.Now, DateTime.Now.AddMonths(1));
            Zadanie zad2 = AddZadanie("Zad.2", "To jest zadanie", DateTime.Now.AddMonths(1), DateTime.Now.AddMonths(5));
            Zadanie zad3 = AddZadanie("Zad.3", "To jest zadanie", DateTime.Now.AddMonths(5), DateTime.Now.AddMonths(6));
            Zadanie zad4 = AddZadanie("Zad.4", "To jest zadanie", DateTime.Now.AddMonths(6), DateTime.Now.AddMonths(7));
            Zadanie zad5 = AddZadanie("Zad.5", "To jest zadanie", DateTime.Now.AddMonths(3), DateTime.Now.AddMonths(10));
            Zadanie zad6 = AddZadanie("Zad.6", "To jest zadanie", DateTime.Now.AddMonths(5), DateTime.Now.AddMonths(6));

            AddProjekt("1. Pierwszy", "A to jest pierwszy projekt", DateTime.Now, DateTime.Now.AddMonths(10), StatusEnum.Odrzucony, zad1, zad2);
            AddProjekt("Drugi", "To jest Drugi projekt", DateTime.Now.AddMonths(5), DateTime.Now.AddMonths(7), StatusEnum.Odrzucony, zad3, zad4);
            AddProjekt("Trzeci", "To jest Trzeci projekt", DateTime.Now.AddMonths(3), DateTime.Now.AddMonths(12), StatusEnum.Przyjety, zad5);
            AddProjekt("Czwarty", "To jest Czwarty projekt", DateTime.Now.AddMonths(5), DateTime.Now.AddMonths(8), StatusEnum.Przyjety, zad6);
            AddProjekt("Pi¹ty", "To jest Pi¹ty projekt", DateTime.Now.AddMonths(1), DateTime.Now.AddMonths(3), StatusEnum.Nowy);
            AddProjekt("Szósty", "To jest Szósty projekt", DateTime.Now.AddMonths(8), DateTime.Now.AddMonths(20), StatusEnum.Nowy);

            AddProjekt("Z Pi¹ty", "To jest Pi¹ty projekt", DateTime.Now.AddMonths(1), DateTime.Now.AddMonths(3), StatusEnum.Nowy);
            AddProjekt("Z Pi¹ty-" + DateTime.Now.Millisecond % 100, "To jest klon", DateTime.Now.AddMonths(1), DateTime.Now.AddMonths(3), StatusEnum.Nowy);
            AddProjekt("Z Pi¹ty-" + DateTime.Now.Millisecond % 100, "To jest klon", DateTime.Now.AddMonths(1), DateTime.Now.AddMonths(3), StatusEnum.Nowy);
            AddProjekt("Z Pi¹ty-" + DateTime.Now.Millisecond % 100, "To jest klon", DateTime.Now.AddMonths(1), DateTime.Now.AddMonths(3), StatusEnum.Nowy);
            AddProjekt("Z Pi¹ty-" + DateTime.Now.Millisecond % 100, "To jest klon", DateTime.Now.AddMonths(1), DateTime.Now.AddMonths(3), StatusEnum.Nowy);
            AddProjekt("Z Pi¹ty-" + DateTime.Now.Millisecond % 100, "To jest klon", DateTime.Now.AddMonths(1), DateTime.Now.AddMonths(3), StatusEnum.Nowy);
            AddProjekt("Z Pi¹ty-" + DateTime.Now.Millisecond % 100, "To jest klon", DateTime.Now.AddMonths(1), DateTime.Now.AddMonths(3), StatusEnum.Nowy);
            AddProjekt("Z Pi¹ty-" + DateTime.Now.Millisecond % 100, "To jest klon", DateTime.Now.AddMonths(1), DateTime.Now.AddMonths(3), StatusEnum.Nowy);
            AddProjekt("Z Pi¹ty-" + DateTime.Now.Millisecond % 100, "To jest klon", DateTime.Now.AddMonths(1), DateTime.Now.AddMonths(3), StatusEnum.Nowy);
            AddProjekt("Z Pi¹ty-" + DateTime.Now.Millisecond % 100, "To jest klon", DateTime.Now.AddMonths(1), DateTime.Now.AddMonths(3), StatusEnum.Nowy);
            AddProjekt("Z Pi¹ty-" + DateTime.Now.Millisecond % 100, "To jest klon", DateTime.Now.AddMonths(1), DateTime.Now.AddMonths(3), StatusEnum.Nowy);
            AddProjekt("Z Pi¹ty-" + DateTime.Now.Millisecond % 100, "To jest klon", DateTime.Now.AddMonths(1), DateTime.Now.AddMonths(3), StatusEnum.Nowy);
            AddProjekt("Z Pi¹ty-" + DateTime.Now.Millisecond % 100, "To jest klon", DateTime.Now.AddMonths(1), DateTime.Now.AddMonths(3), StatusEnum.Nowy);
            AddProjekt("Z Pi¹ty-" + DateTime.Now.Millisecond % 100, "To jest klon", DateTime.Now.AddMonths(1), DateTime.Now.AddMonths(3), StatusEnum.Nowy);
            AddProjekt("Z Pi¹ty-" + DateTime.Now.Millisecond % 100, "To jest klon", DateTime.Now.AddMonths(1), DateTime.Now.AddMonths(3), StatusEnum.Nowy);
            AddProjekt("Z Pi¹ty-" + DateTime.Now.Millisecond % 100, "To jest klon", DateTime.Now.AddMonths(1), DateTime.Now.AddMonths(3), StatusEnum.Nowy);
            AddProjekt("Z Pi¹ty-" + DateTime.Now.Millisecond % 100, "To jest klon", DateTime.Now.AddMonths(1), DateTime.Now.AddMonths(3), StatusEnum.Nowy);
            AddProjekt("Z Pi¹ty-" + DateTime.Now.Millisecond % 100, "To jest klon", DateTime.Now.AddMonths(1), DateTime.Now.AddMonths(3), StatusEnum.Nowy);
            AddProjekt("Z Pi¹ty-" + DateTime.Now.Millisecond % 100, "To jest klon", DateTime.Now.AddMonths(1), DateTime.Now.AddMonths(3), StatusEnum.Nowy);
            AddProjekt("Z Pi¹ty-" + DateTime.Now.Millisecond % 100, "To jest klon", DateTime.Now.AddMonths(1), DateTime.Now.AddMonths(3), StatusEnum.Nowy);
            AddProjekt("Z Pi¹ty-" + DateTime.Now.Millisecond % 100, "To jest klon", DateTime.Now.AddMonths(1), DateTime.Now.AddMonths(3), StatusEnum.Nowy);
            AddProjekt("Z Pi¹ty-" + DateTime.Now.Millisecond % 100, "To jest klon", DateTime.Now.AddMonths(1), DateTime.Now.AddMonths(3), StatusEnum.Nowy);
        }

        private Projekt AddProjekt(string tytulProjektu, string opis, DateTime dataRozpoczecia, DateTime dataZakonczenia, StatusEnum status, params Zadanie[] zadania)
        {
            Projekt item = ObjectSpace.FindObject<Projekt>(new BinaryOperator("TytulProjektu", tytulProjektu));
            if (item == null)
            {
                item = ObjectSpace.CreateObject<Projekt>();
                item.TytulProjektu = tytulProjektu;
                item.DataRozpoczecia = dataRozpoczecia;
                item.DataZakonczenia = dataZakonczenia;
                item.Opis = opis;
                item.Status = status;

                item.Save();
            }
            return item;
        }

        private Zadanie AddZadanie(string nazwa, string opis, DateTime dataRozpoczecia, DateTime dataZakonczenia)
        {
            Zadanie item = ObjectSpace.FindObject<Zadanie>(new BinaryOperator("Nazwa", nazwa));
            if (item == null)
            {
                item = ObjectSpace.CreateObject<Zadanie>();
                item.Nazwa = nazwa;
                item.DataRozpoczecia = dataRozpoczecia;
                item.DataZakonczenia = dataZakonczenia;
                item.Opis = opis;

                item.Save();
            }
            return item;
        }
    }
}
