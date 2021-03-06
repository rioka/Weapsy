using System.Collections.Generic;
using FluentValidation;
using Weapsy.Core.Domain;
using Weapsy.Domain.Menus.Commands;
using System;

namespace Weapsy.Domain.Menus.Handlers
{
    public class AddMenuItemHandler : ICommandHandler<AddMenuItem>
    {
        private readonly IMenuRepository _menuRepository;
        private readonly IValidator<AddMenuItem> _validator;

        public AddMenuItemHandler(IMenuRepository menuRepository,
            IValidator<AddMenuItem> validator)
        {
            _menuRepository = menuRepository;
            _validator = validator;
        }

        public ICollection<IEvent> Handle(AddMenuItem cmd)
        {
            var menu = _menuRepository.GetById(cmd.SiteId, cmd.MenuId);

            if (menu == null)
                throw new Exception("Menu not found");

            menu.AddMenuItem(cmd, _validator);

            _menuRepository.Update(menu);

            return menu.Events;
        }
    }
}
