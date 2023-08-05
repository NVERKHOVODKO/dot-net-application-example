using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Entities;
using Models;
using Repository;

namespace Services
{
    public class OrderService : IOrderService
    {
        private readonly IDbRepository _dbRepository;
        private readonly IMapper _mapper;

        public OrderService(IDbRepository dbRepository, IMapper mapper)
        {
            _dbRepository = dbRepository;
            _mapper = mapper;
        }

        public async Task<Guid> Create(OrderModel order)
        {
            var entity = _mapper.Map<OrderEntity>(order);
            var result = await _dbRepository.Add(entity);

            await _dbRepository.SaveChangesAsync();

            return result;
        }

        public List<OrderModel> GetAll()
        {
            var collection = _dbRepository.GetAll<OrderEntity>().Include(x => x.Lead).ToList();
            var models = _mapper.Map<List<OrderModel>>(collection);

            return models;
        }

        public async Task<OrderModel> Get(Guid id)
        {
            var entity = await _dbRepository.Get<OrderEntity>().Include(x => x.Lead).FirstOrDefaultAsync(x => x.Id == id);
            var model = _mapper.Map<OrderModel>(entity);

            return model;
        }
    }
}