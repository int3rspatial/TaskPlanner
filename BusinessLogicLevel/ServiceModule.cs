using AutoMapper;
using BusinessLogicLevel.Interfaces;
using BusinessLogicLevel.Models;
using BusinessLogicLevel.Services;
using DataAccessLayer;
using DataAccessLayer.Entities;
using DataAccessLayer.Repository;
using DataAccessLayer.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLevel
{
    public class ServiceModule
    {
        ApplicationDbContext dbContext;
        IUnitOfWork unitOfWork;
        Mapper mapper;
        public ITaskService taskService { get; }
        public ServiceModule()
        {
            dbContext = new ApplicationDbContext();
            unitOfWork = new UnitOfWork(dbContext);
            mapper = new Mapper(ConfigurateMapper());
            taskService = new TaskService(mapper, unitOfWork);
        }
        private MapperConfiguration ConfigurateMapper()
        {
            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<DataAccessLayer.Entities.Task, TaskModel>()
                .ReverseMap();
                cfg.CreateMap<Employee, EmployeeModel>()
                .ReverseMap();
            });
            return mapperConfig;
        }
    }
}
