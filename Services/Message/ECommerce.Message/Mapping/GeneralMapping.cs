using AutoMapper;
using ECommerce.Message.DAL.Entities;
using ECommerce.Message.Dtos;
using Microsoft.AspNetCore.Identity;

namespace ECommerce.Message.Mapping
{
    public class GeneralMapping:Profile
    {
        public GeneralMapping()
        {
            CreateMap<UserMessage, ResultMessageDto>().ReverseMap();       
            CreateMap<UserMessage, CreateMessageDto>().ReverseMap();       
            CreateMap<UserMessage, UpdateMessageDto>().ReverseMap();       
            CreateMap<UserMessage, ResultInboxMessageDto>().ReverseMap();       
            CreateMap<UserMessage, ResultSendboxMessageDto>().ReverseMap();       
            CreateMap<UserMessage, GetByIdMessageDto>().ReverseMap();       
        }
    }
}
