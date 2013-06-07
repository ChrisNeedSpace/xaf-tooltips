using System;
using System.Collections.Generic;
using System.ComponentModel;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using SampleProject.Module.Infrastructure;

namespace SampleProject.Module.BusinessObjects
{
    [DefaultClassOptions]
    [DefaultProperty("TytulProjektu")]
    public class Projekt : BaseObject
    {
        public Projekt(Session session) : base(session) { }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

        private String m_tytulProjektu;
        [Size(50)]
        [RuleRequiredField("normal_rule", DefaultContexts.Save)]
        public String TytulProjektu
        {
            get { return m_tytulProjektu; }
            set { SetPropertyValue("TytulProjektu", ref m_tytulProjektu, value); }
        }

        private StatusEnum status;
        [Tooltip("This is a sample tooltip from an <br/><br/>(some BR tags)<br/><br/><br/><br/>attribute")]
        public StatusEnum Status
        {
            get { return status; }
            set { SetPropertyValue("Status", ref status, value); }
        }

        private String m_opis;
        [Size(50)]
        [Tooltip("This is tooltip will be overriden in the designer. It shouldn't show up.")]
        public String Opis
        {
            get { return m_opis; }
            set { SetPropertyValue("Opis", ref m_opis, value); }
        }

        private String opis2;
        [Size(50)]
        public String Opis2
        {
            get { return opis2; }
            set { SetPropertyValue("Opis2", ref opis2, value); }
        }

        private String opis3;
        [Size(50)]
        public String Opis3
        {
            get { return opis3; }
            set { SetPropertyValue("Opis3", ref opis3, value); }
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

        [Association]
        public XPCollection<Zadanie> Zadania
        {
            get { return GetCollection<Zadanie>("Zadania"); }
        }
    }

}







