using HotChocolate.Authorization;
using BLL.Interfaces;
using DAL.Entities;
using DAL.Interfaces;

namespace AspGraphReact.API
{
    [Authorize]
    public class InfoQuery
    {
        private readonly ICardInfoService _cardInfoService;
        private readonly IUserService _userService;

        public InfoQuery(ICardInfoService cardInfoService, IUserService userService)
        {
            _cardInfoService = cardInfoService;
            _userService = userService;
        }

        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<InfoCard> GetCards()
        {
            return _cardInfoService.GetAllQuery();
        }

        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<User> GetUsers()
        {
            return _userService.GetAllQuery();
        }

    }
}
