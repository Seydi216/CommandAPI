using AutoMapper;
using preparing.Dtos;
using preparing.Models;


namespace preparing.Profiles
{
    public class CommandsProfile: Profile
    {
     
        public CommandsProfile() {
            CreateMap<Command, CommandReadDto>();
        }
    }
}
