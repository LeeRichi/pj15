﻿using MediaPlayer.src.Infrastructure.Repository;
using MediaPlayer.src.Business.Sevice;
using MediaPlayer.Domain.src.Core;

using MediaPlayer.src.Application;

internal class Program
{
    private static void Main(string[] args)
    {
        // how client interact with application - via controllers
        var user = User.Instance;
        var userRepository = new UserRepository();
        var userService = new UserService(userRepository);
        var userController = new UserController(userService);
   
        var mediaRepository = new MediaRepository();
        var mediaService = new MediaService(mediaRepository);
        var mediaController = new MediaController(mediaService);

        var playListRepository = new PlayListRepository();
        var playListService = new PlayListService(playListRepository);
        var playListController = new PlayListController(playListService);

        /* command-line interface should be here. All the methods should be used from class controllers only */
    }
}