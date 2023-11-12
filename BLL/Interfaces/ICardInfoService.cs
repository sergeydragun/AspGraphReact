using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface ICardInfoService
    {
        IQueryable<InfoCard> GetAllQuery();
        Task<List<InfoCard>> GetAllCards();

        Task<InfoCard?> GetCardById(int cardId);

        Task<List<InfoCard>> GetCardsAssignedToUser(User user);
    }
}
