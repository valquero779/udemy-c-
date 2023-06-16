﻿using AutoMapper;
using CleanArchitecture.Application.Contracts.Persistence;
using MediatR;


namespace CleanArchitecture.Application.Features.Videos.Queries.GetVideoList
{
    public class GetVideosListQueryHandler : IRequestHandler<GetVideosListQuery, List<VideosVm>>


    {
        private readonly IVideoRepository _videoRepository;
        private readonly IMapper _mapper;

        public GetVideosListQueryHandler(IVideoRepository videoRepository, IMapper mapper)
        {
            _videoRepository = videoRepository;
            _mapper = mapper;
        }

        async Task<List<VideosVm>> IRequestHandler<GetVideosListQuery, List<VideosVm>>.Handle(GetVideosListQuery request, CancellationToken cancellationToken)
        {
            var videoList = await _videoRepository.GetVideoByUsername(request._Username);
            return _mapper.Map<List<VideosVm>>(videoList);
        }
    }
}
