﻿using System;
using System.Threading;
using System.Threading.Tasks;
using FFImageLoading.Config;

namespace FFImageLoading.Work
{
    [Preserve(AllMembers = true)]
    public interface IImageLoaderTask : IScheduledWork, IDisposable
    {
        Task Init();

        TaskParameter Parameters { get; }

        bool CanUseMemoryCache { get; }

        string Key { get; }

        string KeyRaw { get; }

        void CancelIfNeeded();

        Task<bool> TryLoadFromMemoryCacheAsync();

        Task RunAsync();

        bool UsesSameNativeControl(IImageLoaderTask anotherTask);

        ITarget Target { get; }

        Configuration Configuration { get; }

        ImageInformation ImageInformation { get; }

        DownloadInformation DownloadInformation { get; }
    }
}

