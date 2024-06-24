using System.Data.Entity.Infrastructure;

namespace PRJ_CONSOLIDADOR.Models
{
    public class SUPERMERCADO_AYUMI : System.Data.Entity.DbContext
    {
        public SUPERMERCADO_AYUMI()
            
        {
            this.SetCommandTimeOut(0);
        }

        public void SetCommandTimeOut(int Timeout)
        {
            var objectContext = (this as IObjectContextAdapter).ObjectContext;
            objectContext.CommandTimeout = Timeout;
        }
        public System.Data.Entity.DbSet<TB_CAT17_EXTRATOR> TB_CAT17_EXTRATOR { get; set; }
    }
}
