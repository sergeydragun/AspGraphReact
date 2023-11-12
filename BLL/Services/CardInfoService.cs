using AutoMapper;
using BLL.Interfaces;
using DAL.Entities;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class CardInfoService : BaseService, ICardInfoService
    {
        public CardInfoService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<List<InfoCard>> GetAllCards()
        {
            var cards = await _database.InfoCards.FindAll().ToListAsync();

            return cards;
        }

        public IQueryable<InfoCard> GetAllQuery()
        {
            return _database.InfoCards.FindAll();
        }

        public async Task<InfoCard?> GetCardById(int cardId)
        {
            var card = await _database.InfoCards.FirstOrDefaultAsync(c => c.Id == cardId);

            return card;
        }

        public async Task<List<InfoCard>> GetCardsAssignedToUser(User user)
        {
            var cards = await _database.InfoCards.FindByCondition(c => c.AssignedUsers != null && c.AssignedUsers.Count > 0 && 
                                                                  c.AssignedUsers.Any(u => u.Email == user.Email)).ToListAsync();

            return cards;
        }
    }
}
