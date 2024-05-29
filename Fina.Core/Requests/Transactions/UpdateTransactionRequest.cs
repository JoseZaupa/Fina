﻿using Fina.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fina.Core.Requests.Transactions
{
	public class UpdateTransactionRequest : Request
	{
		public long Id { get; set; }

		[Required(ErrorMessage = "Título inválido")]
		public string Title { get; set; } = string.Empty;

		[Required(ErrorMessage = "Tipo inválido")]
		public ETransactionType Type { get; set; } = ETransactionType.Withdraw;

		[Required(ErrorMessage = "Valor inválido")]
		public decimal Amount { get; set; }

		[Required(ErrorMessage = "Categoria inválida")]
		public long CategoryId { get; set; }

		public DateTime? PaidOrReceived { get; set; }
	}
}