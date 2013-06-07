using System;
using System.ComponentModel;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;

namespace SampleProject.Module.BusinessObjects
{
    [DefaultClassOptions]
    [DefaultProperty("Nazwa")]
    public class Zadanie : BaseObject
    {
        public Zadanie() { }
        public Zadanie(Session session) : base(session) { }
        public override void AfterConstruction()
        {
            base.AfterConstruction();         
        }

        private String m_nazwa;
        [Size(50)]
        public String Nazwa
        {
            get { return m_nazwa; }
            set { SetPropertyValue("Nazwa", ref m_nazwa, value); }
        }

        private String m_opis;
        [Size(50)]
        public String Opis
        {
            get { return m_opis; }
            set { SetPropertyValue("Opis", ref m_opis, value); }
        }

        private String m_czasTrwania;
        [Size(50)]
        public String CzasTrwania
        {
            get { return m_czasTrwania; }
            set { SetPropertyValue("CzasTrwania", ref m_czasTrwania, value); }
        }

        private DateTime m_dataRozpoczecia;
        public DateTime DataRozpoczecia
        {
            get { return m_dataRozpoczecia; }
            set { SetPropertyValue("DataRozpoczecia", ref m_dataRozpoczecia, value); }
        }

        private DateTime m_dataZakonczenia;
        public DateTime DataZakonczenia
        {
            get { return m_dataZakonczenia; }
            set { SetPropertyValue("DataZakonczenia", ref m_dataZakonczenia, value); }
        }

        private Projekt m_Projekt;
        [Association]
        [DevExpress.Xpo.DisplayName("Projekt")]
        public Projekt Projekt
        {
            get { return m_Projekt; }
            set { SetPropertyValue("Projekt", ref m_Projekt, value); }
        }
    }

}
