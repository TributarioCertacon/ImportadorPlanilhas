using PRJ_CONSOLIDADOR.Models.Certacon;
using System.Data.Entity.Infrastructure;

namespace PRJ_CONSOLIDADOR.Models
{
    public class CertaconWeb : System.Data.Entity.DbContext
    {
        public CertaconWeb()

        {
            this.SetCommandTimeOut(0);
        }

        public void SetCommandTimeOut(int Timeout)
        {
            var objectContext = (this as IObjectContextAdapter).ObjectContext;
            objectContext.CommandTimeout = Timeout;
        }
        public System.Data.Entity.DbSet<CD_Parceiro> CD_Parceiro { get; set; }
    }
}