using HotChocolate.Authorization;
using BLL.Interfaces;
using DAL.Entities;

namespace AspGraphReact.API
{
    [Authorize]
    public class InfoQuery
    {
        private readonly ICardInfoService _cardInfoService;

        public InfoQuery(ICardInfoService cardInfoService)
        {
            _cardInfoService = cardInfoService;
        }

        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<InfoCard> GetCards()
        {
            return _cardInfoService.GetAllQuery();
        }

    }
}
