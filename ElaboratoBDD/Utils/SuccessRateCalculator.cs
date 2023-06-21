using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElaboratoBDD.Utils
{
    internal class SuccessRateCalculator
    {
        private ModelAgencyDataContext ctx;

        public SuccessRateCalculator(ModelAgencyDataContext ctx)
        {
            this.ctx = ctx;
        }


        public void UpdateSuccessRateFromProposal(proposal p)
        {
            var model = p.Model;

            decimal totProposals=(from prop in ctx.proposal
                              where prop.model_iden_card_numb==model.iden_card_numb
                              select prop).Count();

            decimal approvedProposals= (from prop in ctx.proposal
                                    where prop.model_iden_card_numb == model.iden_card_numb
                                    where prop.status=='a'
                                    select prop).Count();

            model.success_rate = (decimal)(approvedProposals / totProposals);

            ctx.SubmitChanges();
        }

        public void UpdateSuccessRateFromOffer(Offer offer)
        {
            var props = from p in ctx.proposal
                        where p.codOffer == offer.codOffer
                        select p;

            foreach(var prop in props)
            {
                this.UpdateSuccessRateFromProposal(prop);
            }
        }
    }
}
