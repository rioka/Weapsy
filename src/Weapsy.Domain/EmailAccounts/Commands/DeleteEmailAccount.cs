﻿using System;
using Weapsy.Core.Domain;

namespace Weapsy.Domain.EmailAccounts.Commands
{
    public class DeleteEmailAccount : ICommand
    {
        public Guid SiteId { get; set; }
        public Guid Id { get; set; }
    }
}
