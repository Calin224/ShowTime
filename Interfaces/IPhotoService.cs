using System;
using CloudinaryDotNet.Actions;
using Microsoft.AspNetCore.Components.Forms;

namespace STime.Interfaces;

public interface IPhotoService
{
    Task<List<ImageUploadResult>> AddPhotosAsync(IBrowserFile? file);
    Task<DeletionResult> DeletePhotoAsync(string publicId);
}
