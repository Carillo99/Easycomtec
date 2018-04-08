using System.Collections.Generic;
using System.Data.Entity;

namespace Easycomtec.Models
{
    public class CandidatesSeed : CreateDatabaseIfNotExists<CandidatesContext>
    {
        protected override void Seed(CandidatesContext context)
        {

            List<Candidates> candidates = new List<Candidates>()
            {
                new Candidates() { CandidateID = 1, Email = "gleissoncarillo@gmail.com"},
                new Candidates() { CandidateID = 2, Email = "gleissoncarillo@ghotmail.com"},
                new Candidates() { CandidateID = 3, Email = "gleissoncarillo@yahoo.com"},
                new Candidates() { CandidateID = 4, Email = "carillo@gmail.com"},
                new Candidates() { CandidateID = 5, Email = "Larissa@gmail.com"},
                new Candidates() { CandidateID = 6, Email = "Adonias@gmail.com"},
                new Candidates() { CandidateID = 7, Email = "Gerasud@gmail.com"},
                new Candidates() { CandidateID = 8, Email = "flavio@gmail.com"},
                new Candidates() { CandidateID = 9, Email = "Cleviton@gmail.com"},
                new Candidates() { CandidateID = 10, Email = "Darcio@gmail.com"}
            };
            candidates.ForEach(g => context.Candidates.Add(g));
            context.SaveChanges();
            List<OccupationArea> occupationArea = new List<OccupationArea>()
            {
                new OccupationArea() { OccupationAreaID = 1, Name = "Gleisson", Skype ="gleisson.carillo" , Linkedin ="www.linkedin.com/in/gleisson-carillo", Cyte = "Itabuna", State = "Bahia", Portfolio = "github.com/Carillo99", Willingness ="Up to 4 hours per day", Horary = "from 08:00 a.m. to 06:00 p.m.", Salary= 20},
                new OccupationArea() { OccupationAreaID = 2, Name = "Gleisson", Skype ="gleisson.carillo" , Linkedin ="www.linkedin.com/in/gleisson-carillo", Cyte = "Itabuna", State = "Bahia", Portfolio = "github.com/Carillo99", Willingness ="4 to 6 hours per day", Horary = "7:00 p.m. to 10:00 p.m.", Salary= 15},
                new OccupationArea() { OccupationAreaID = 3, Name = "Gleisson", Skype ="gleisson.carillo" , Linkedin ="www.linkedin.com/in/gleisson-carillo", Cyte = "Itabuna", State = "Bahia", Portfolio = "github.com/Carillo99", Willingness ="6 to 8 hours per day", Horary = "from 10 p.m. onwards", Salary= 25},
                new OccupationArea() { OccupationAreaID = 4, Name = "Gleisson", Skype ="gleisson.carillo" , Linkedin ="www.linkedin.com/in/gleisson-carillo", Cyte = "Itabuna", State = "Bahia", Portfolio = "github.com/Carillo99", Willingness ="Up to 8 hours a day", Horary = "from 10 p.m. onwards", Salary= 30},

                new OccupationArea() { OccupationAreaID = 5, Name = "Larissa", Skype ="Larissa" , Linkedin ="www.linkedin.com/in/Larissa", Cyte = "Santa Cruz Da Vitoria", State = "Bahia", Portfolio = "github.com/Larissa", Willingness ="Up to 4 hours per day", Horary = "from 08:00 a.m. to 06:00 p.m.", Salary= 20},
                new OccupationArea() { OccupationAreaID = 6, Name = "Adonias", Skype ="Adonias" , Linkedin ="www.linkedin.com/in/Adonias", Cyte = "Salvador", State = "Bahia", Portfolio = "github.com/Adonias", Willingness ="4 to 6 hours per day", Horary = "7:00 p.m. to 10:00 p.m.", Salary= 15},
                new OccupationArea() { OccupationAreaID = 7, Name = "Gerasud", Skype ="Gerasud" , Linkedin ="www.linkedin.com/in/Gerasud", Cyte = "Salvador", State = "Bahia", Portfolio = "github.com/Gerasud", Willingness ="6 to 8 hours per day", Horary = "from 10 p.m. onwards", Salary= 25},
                new OccupationArea() { OccupationAreaID = 8, Name = "Flávio", Skype ="Flávio" , Linkedin ="www.linkedin.com/in/Flávio", Cyte = "Salvador", State = "Bahia", Portfolio = "github.com/Flavio", Willingness ="Up to 8 hours a day", Horary = "from 10 p.m. onwards", Salary= 30},

                new OccupationArea() { OccupationAreaID = 9, Name = "Cleviton", Skype ="Cleviton" , Linkedin ="www.linkedin.com/in/Cleviton", Cyte = "Alagoinhas", State = "Bahia", Portfolio = "github.com/Cleviton", Willingness ="Up to 4 hours per day", Horary = "from 08:00 a.m. to 06:00 p.m.", Salary= 20},
                new OccupationArea() { OccupationAreaID = 10, Name = "Dacio", Skype ="Darcio" , Linkedin ="www.linkedin.com/in/Darcio", Cyte = "Paulo Afonso", State = "Bahia", Portfolio = "github.com/Darcio", Willingness ="4 to 6 hours per day", Horary = "7:00 p.m. to 10:00 p.m.", Salary= 15}

            };

            occupationArea.ForEach(g => context.OccupationArea.Add(g));
            context.SaveChanges();
            List<InformationBank> InformationBank = new List<InformationBank>()
            {
                new InformationBank() { InformationBankID = 1, Cpf = "05453390573", BanK = "Banco do Brasil", Agency = "00191", AccountType = "Corrente", AccountNumber= "59913-1"},
                new InformationBank() { InformationBankID = 2, Cpf = "05453390573", BanK = "Banco do Brasil", Agency = "00191", AccountType = "Corrente", AccountNumber= "59913-1"},
                new InformationBank() { InformationBankID = 3, Cpf = "05453390573", BanK = "Banco do Brasil", Agency = "00191", AccountType = "Corrente", AccountNumber= "59913-1"},
                new InformationBank() { InformationBankID = 4, Cpf = "05453390573", BanK = "Banco do Brasil", Agency = "00191", AccountType = "Corrente", AccountNumber= "59913-1"},
                new InformationBank() { InformationBankID = 5, Cpf = "22059844622", BanK = "Bradesco", Agency = "3587", AccountType = "Corrente", AccountNumber= "0741278-9"},
                new InformationBank() { InformationBankID = 6, Cpf = "28034717878", BanK = "Bradesco", Agency = "3651", AccountType = "Corrente", AccountNumber= "0863692-3"},
                new InformationBank() { InformationBankID = 7, Cpf = "51257672207", BanK = "Bradesco", Agency = "3646", AccountType = "Corrente", AccountNumber= "0157081-1"},
                new InformationBank() { InformationBankID = 8, Cpf = "79718187774", BanK = "Itau", Agency = "0697", AccountType = "Corrente", AccountNumber= "71135-6"},
                new InformationBank() { InformationBankID = 9, Cpf = "46443165128", BanK = "Itau", Agency = "1647", AccountType = "Corrente", AccountNumber= "09817-5"},
                new InformationBank() { InformationBankID = 10, Cpf = "79932347604", BanK = "Itau", Agency = "7188", AccountType = "Corrente", AccountNumber= "74621-3"}
            };

            InformationBank.ForEach(g => context.InformationBank.Add(g));
            context.SaveChanges();
            List<Knowledge> knowledge = new List<Knowledge>()
            {
                new Knowledge() { KnowledgeID =1, Ionic =4, Android =4, Ios =4,  Majento =2, WordPress =4, Html =3, Css =2, Bootstrap =2, Django =3, Jquery=2, Angular =3, Vue = 3,
                                SqlServer =4,MySql =5,Java =5, Phyton=1, Cake =3,Php =2, AspNetMvc =3,Ruby =3, C =0, C_ =0, Photoshop =0,Illustraitor =0,  Salesforce =1,Seo =1,
                                OtherLanguage = "JS - 5", Crud = "github.com/Carillo99"},

                new Knowledge() { KnowledgeID =2, Ionic =1, Android =1, Ios =1,  Majento =2, WordPress =4, Html =3, Css =2, Bootstrap =2, Django =3, Jquery=2, Angular =3, Vue = 3,
                                SqlServer =4,MySql =4,Java =4, Phyton=1, Cake =3,Php =2, AspNetMvc =3,Ruby =4, C =1, C_ =1, Photoshop =0,Illustraitor =0,  Salesforce =1,Seo =1,
                                OtherLanguage = "JS - 5", Crud = "github.com/Carillo99"},

                new Knowledge() { KnowledgeID =3, Ionic =1, Android =1, Ios =1,  Majento =5, WordPress =4, Html =3, Css =5, Bootstrap =2, Django =3, Jquery=2, Angular =3, Vue = 3,
                                SqlServer =4,MySql =4,Java =4, Phyton=1, Cake =3,Php =2, AspNetMvc =3,Ruby =4, C =0, C_ =0, Photoshop =0,Illustraitor =0,  Salesforce =1,Seo =1,
                                OtherLanguage = "JS - 5", Crud = "github.com/Carillo99"},

                new Knowledge() { KnowledgeID =4, Ionic =4, Android =4, Ios =4,  Majento =2, WordPress =4, Html =3, Css =2, Bootstrap =2, Django =3, Jquery=2, Angular =3, Vue = 3,
                                SqlServer =4,MySql =4,Java =4, Phyton=1, Cake =3,Php =2, AspNetMvc =3,Ruby =4, C =3, C_ =3, Photoshop =0,Illustraitor =0,  Salesforce =1,Seo =1,
                                OtherLanguage = "JS - 3", Crud = "github.com/Carillo99"},

                new Knowledge() { KnowledgeID =5, Ionic =4, Android =4, Ios =4,  Majento =2, WordPress =4, Html =3, Css =2, Bootstrap =2, Django =3, Jquery=2, Angular =3, Vue = 3,
                                SqlServer =4,MySql =4,Java =4, Phyton=1, Cake =3,Php =2, AspNetMvc =3,Ruby =4, C =0, C_ =0, Photoshop =0,Illustraitor =0,  Salesforce =1,Seo =1,
                                OtherLanguage = "JS - 3", Crud = "github.com/Larissa"},

                new Knowledge() { KnowledgeID =6, Ionic =3, Android =3, Ios =2,  Majento =2, WordPress =2, Html =3, Css =2, Bootstrap =2, Django =3, Jquery=2, Angular =3, Vue = 3,
                                SqlServer =1,MySql =5,Java =5, Phyton=1, Cake =3,Php =2, AspNetMvc =3,Ruby =5, C =0, C_ =0, Photoshop =0,Illustraitor =0,  Salesforce =1,Seo =1,
                                OtherLanguage = "JS - 5", Crud = "github.com/Adonias"},

                new Knowledge() { KnowledgeID =7, Ionic =5, Android =5, Ios =5,  Majento =2, WordPress =0, Html =3, Css =2, Bootstrap =2, Django =3, Jquery=2, Angular =3, Vue = 3,
                                SqlServer =0,MySql =0,Java =1, Phyton=1, Cake =3,Php =2, AspNetMvc =3,Ruby =5, C =0, C_ =0, Photoshop =0,Illustraitor =0,  Salesforce =1,Seo =1,
                                OtherLanguage = "JS - 5", Crud = "github.com/Gerasud"},

                new Knowledge() { KnowledgeID =8, Ionic =3, Android =3, Ios =3,  Majento =2, WordPress =3, Html =3, Css =2, Bootstrap =2, Django =3, Jquery=2, Angular =3, Vue = 3,
                                SqlServer =3,MySql =1,Java =1, Phyton=1, Cake =3,Php =2, AspNetMvc =3,Ruby =1, C =5, C_ =5, Photoshop =0,Illustraitor =0,  Salesforce =1,Seo =1,
                                OtherLanguage = "JS - 5", Crud = "github.com/Flavio"},

                new Knowledge() { KnowledgeID =9, Ionic =2, Android =2, Ios =2,  Majento =2, WordPress =2, Html =3, Css =2, Bootstrap =2, Django =3, Jquery=2, Angular =3, Vue = 3,
                                SqlServer =2,MySql =2,Java =2, Phyton=1, Cake =3,Php =2, AspNetMvc =3,Ruby =2, C =5, C_ =5, Photoshop =5,Illustraitor =5,  Salesforce =1,Seo =1,
                                OtherLanguage = "JS - 5", Crud = "github.com/Cleviton"},

                new Knowledge() { KnowledgeID =10, Ionic =3, Android =1, Ios =1,  Majento =2, WordPress =1, Html =5, Css =2, Bootstrap =2, Django =5, Jquery=2, Angular =5, Vue = 5, 
                                SqlServer =1,MySql =1,Java =1, Phyton=1, Cake =5,Php =2, AspNetMvc =5,Ruby =1, C =0, C_ =0, Photoshop =0,Illustraitor =0,  Salesforce =1,Seo =1,
                                OtherLanguage = "JS - 5", Crud = "github.com/Darcio"}
            };

            knowledge.ForEach(g => context.Knowledge.Add(g));
            context.SaveChanges();
        }
    }
}
