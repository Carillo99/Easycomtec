using Easycomtec.Models;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace Easycomtec.Controllers
{
    public class HomeofficeController : Controller
    {
        private CandidatesContext db = new CandidatesContext();

        public ActionResult Edit()
        {            
            ViewData["Candidate"] = TempData["Candidates"] as Candidates;
            return View();
        }

        public ActionResult Developer()
        {
            return View();
        }

        // POST: Homeoffice/Developer
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Developer(CandidatesModel model)
        {
            if (ModelState.IsValid)
            {
                db.Candidates.Add(model.Candidates);
                model.OccupationArea = OccupationArea(model);
                model.InformationBank = InformationBank(model);
                model.Knowledge = Knowledge(model);

                db.SaveChanges();

                TempData["Candidates"] = model.Candidates;

                return RedirectToAction("Edit","Homeoffice");

            }

            return View(model);
        }
        
        public OccupationArea OccupationArea(CandidatesModel model)
        {
            var occupation = new OccupationArea()
            {
                OccupationAreaID = model.Candidates.CandidateID,
                Name = model.OccupationArea.Name,
                Skype = model.OccupationArea.Skype,
                Linkedin = model.OccupationArea.Linkedin,
                Cyte = model.OccupationArea.Cyte,
                State = model.OccupationArea.State,
                Portfolio = model.OccupationArea.Portfolio,
                Willingness = model.OccupationArea.Willingness,
                Horary = model.OccupationArea.Horary,
                Salary = model.OccupationArea.Salary,
            };

            db.OccupationArea.Add(occupation);

            return occupation;
        }

        public InformationBank InformationBank(CandidatesModel model)
        {
            var information = new InformationBank()
            {
                InformationBankID = model.Candidates.CandidateID,
                Cpf = model.InformationBank.Cpf,
                BanK = model.InformationBank.BanK,
                Agency = model.InformationBank.Agency,
                AccountType = model.InformationBank.AccountType,
                AccountNumber = model.InformationBank.AccountNumber
            };
            db.InformationBank.Add(information);

            return information;
        }

        public Knowledge Knowledge(CandidatesModel model)
        {
            var knowledge = new Knowledge()
            {
                KnowledgeID = model.Candidates.CandidateID,
                Ionic = model.Knowledge.Ionic,
                Android = model.Knowledge.Android,
                Ios = model.Knowledge.Ios,
                Majento = model.Knowledge.Majento,
                WordPress = model.Knowledge.WordPress,
                Html = model.Knowledge.Html,
                Css = model.Knowledge.Css,
                Bootstrap = model.Knowledge.Bootstrap,
                Django = model.Knowledge.Django,
                Jquery = model.Knowledge.Jquery,
                Angular = model.Knowledge.Angular,
                Vue = model.Knowledge.Vue,
                SqlServer = model.Knowledge.SqlServer,
                MySql = model.Knowledge.MySql,
                Java = model.Knowledge.Java,
                Phyton = model.Knowledge.Phyton,
                Cake = model.Knowledge.Cake,
                Php = model.Knowledge.Php,
                AspNetMvc = model.Knowledge.AspNetMvc,
                Ruby = model.Knowledge.Ruby,
                C = model.Knowledge.C,
                C_ = model.Knowledge.C_,
                Photoshop = model.Knowledge.Photoshop,
                Illustraitor = model.Knowledge.Illustraitor,
                Salesforce = model.Knowledge.Salesforce,
                Seo = model.Knowledge.Seo,
                OtherLanguage = model.Knowledge.OtherLanguage,
                Crud = model.Knowledge.Crud,
            };
            db.Knowledge.Add(knowledge);

            return knowledge;
        }


        // GET: Knowledges/Edit/5
        public ActionResult DeveloperEdit(int? id)
        {
            var model = new CandidatesModel();

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Candidates candidates = db.Candidates.Find(id);
            OccupationArea occupationArea = db.OccupationArea.Find(id);
            InformationBank informationBank = db.InformationBank.Find(id);
            Knowledge knowledge = db.Knowledge.Find(id);

            model.Candidates = candidates;
            model.OccupationArea = occupationArea;
            model.InformationBank = informationBank;
            model.Knowledge = knowledge;


            if (model == null)
            {
                return HttpNotFound();
            }

            return View(model);
        }

        // POST: Knowledges/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeveloperEdit(CandidatesModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Entry(model.Candidates).State = EntityState.Modified;
                    db.Entry(model.OccupationArea).State = EntityState.Modified;
                    db.Entry(model.InformationBank).State = EntityState.Modified;
                    db.Entry(model.Knowledge).State = EntityState.Modified;

                    db.SaveChanges();

                    return RedirectToAction("Developer", "Homeoffice");
                }
            }
            catch (DbUpdateConcurrencyException ex)
            {

                // Update the values of the entity that failed to save from the store 
                ex.Entries.Single().Reload();
            }

            return View(model);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
