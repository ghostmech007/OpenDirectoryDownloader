﻿namespace OpenDirectoryDownloader.Shared
{
    public class SpeedtestResult
    {
        public long DownloadedBytes { get; set; }
        public double DownloadedMBs => DownloadedBytes / 1024d / 1024d;
        public long ElapsedMilliseconds { get; set; }
        public double MBsPerSecond => DownloadedMBs / (ElapsedMilliseconds / 1000d);
        public double MbitsPerSecond => DownloadedMBs / (ElapsedMilliseconds / 1000d) * 8;
        public double MaxMBsPerSecond { get; set; }
    }
}
