﻿using AutoMapper;
using BusinessLogicLevel.Interfaces;
using BusinessLogicLevel.Models;
using DataAccessLayer.Repository.IRepository;
using Task = DataAccessLayer.Entities.Task;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLevel.Services
{
    public class TaskService : ITaskService
    {
        private Mapper _mapper;
        private IUnitOfWork _database;
        public TaskService(Mapper mapper, IUnitOfWork database)
        {
            _mapper = mapper;
            _database = database;
        }

        public void CreateTask(TaskModel taskModel)
        {
            if(taskModel.Title != String.Empty && taskModel.EstimatedTime != 0)
            {
                _database.Tasks.Add(_mapper.Map<Task>(taskModel));
                _database.SaveChanges();
            }
        }

        public void DeleteTask(int taskId)//don`t forget to edit this, when you create EmployeeService
        {
            Task task = _database.Tasks.GetFirstOrDefault(x => x.Id == taskId);
            _database.Tasks.Remove(task);
            _database.SaveChanges();
        }

        public TaskModel GetTaskById(int taskId)
        {
            Task task = _database.Tasks.GetFirstOrDefault(x => x.Id == taskId);
            return _mapper.Map<TaskModel>(task);
        }

        public IEnumerable<TaskModel> GetTasks()
        {
            return _mapper.Map<IEnumerable<TaskModel>>(_database.Tasks.GetAll());
        }
    }
}
