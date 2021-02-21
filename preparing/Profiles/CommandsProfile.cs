using AutoMapper;
using preparing.Dtos;
using preparing.Models;


namespace preparing.Profiles
{
    public class CommandsProfile: Profile
    {
        public CommandsProfile() {
            CreateMap<Command, CommandReadDto>();
            CreateMap<CommandCreateDto, Command>();
            CreateMap<CommandUpdateDto, Command>();
            CreateMap<Command, CommandUpdateDto>();
        }
    }
}
