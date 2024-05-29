using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fina.Core.Requests.Transactions
{
	public class GetTransactionsByPeriodRequest : PagedRequest
	{
		public DateTime? StarDate { get; set; }
		public DateTime? EndDate { get;set; }
	}
}
