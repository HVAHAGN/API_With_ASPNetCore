using AutoMapper;
using CoreCodeCamp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreCodeCamp.Data
{
    public class CampProfile:Profile
    {
        public CampProfile()
        {
            this.CreateMap<Camp, CampModel>()
                .ForMember(x=>x.Venue, src=>src.MapFrom(x=>x.Location.VenueName))
                .ReverseMap();
            //this.CreateMap<CampModel, Camp>();
            this.CreateMap<Talk, TalkModel>()               
                .ReverseMap()
                .ForMember(x=>x.Camp, src=>src.Ignore())
                .ForMember(x=>x.Speaker, src=>src.Ignore());
            this.CreateMap<Speaker, SpeakerModel>().
                ReverseMap();
        }
    }
}
