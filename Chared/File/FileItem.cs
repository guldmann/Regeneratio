using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chared.File
{
	public class FileItem : IEquatable<FileItem>
	{
		public string FileName { get; set; }
		public string  Md5 { get; set; }
		public string RootPath { get; set; }

		public bool Equals(FileItem other)
		{
			if(ReferenceEquals(other, null))
				return false;

			// Check whether the compared object references the same data.
			if(ReferenceEquals(this, other))
				return true;

			// Check whether the objects’ properties are equal.
			return FileName.Equals(other.FileName)
					&& RootPath.Equals(other.RootPath)
					&& Md5.Equals(other.Md5);
		}

		public int GetHashCode(FileItem fileItem)
		{
			// Get the hash code for the FileName field if it is not null.
			int hashName = fileItem.FileName ?.GetHashCode() ?? 0;

			// Get the hash code for the Md5 field if it is not null.
			int hashMD5 = fileItem.Md5?.GetHashCode() ?? 0;

			// Get the hash code for the FolderName field if it is not null.
			int hashFolder = fileItem.RootPath?.GetHashCode() ?? 0;

			// Calculate the hash code for the object.
			return hashName ^ hashMD5 ^ hashFolder;
		}
	}
}
