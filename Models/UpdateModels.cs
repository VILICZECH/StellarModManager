using System;

namespace StellarModManager.Models;

public record UpdateInfo(Version Version, GitHubAsset[] Assets, string ReleaseNotes, string ReleaseUrl);
public record GitHubRelease(string tag_name, GitHubAsset[] assets, string body, DateTime? published_at, string html_url);
public record GitHubAsset(string name, string browser_download_url, long size, long download_count);
public record ChangelogEntry(Version Version, string Notes);