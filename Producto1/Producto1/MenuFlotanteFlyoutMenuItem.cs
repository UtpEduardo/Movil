using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Producto1
{
    public class MenuFlotanteFlyoutMenuItem
    {
        public MenuFlotanteFlyoutMenuItem()
        {
            TargetType = typeof(MenuFlotanteFlyoutMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
        public string IconSource { get; set; }
    }
}