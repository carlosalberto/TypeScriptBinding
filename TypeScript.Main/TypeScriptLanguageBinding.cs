using System;
using System.IO;

using MonoDevelop.Core;
using MonoDevelop.Projects;

namespace TypeScript.Main
{
	public class TypeScriptLanguageBinding : ILanguageBinding
	{
		public TypeScriptLanguageBinding ()
		{
		}

		public string Language {
			get { return "TypeScript"; }
		}

		public string SingleLineCommentTag {
			get { return "//"; }
		}

		public string BlockCommentStartTag {
			get { return "/*"; }
		}

		public string BlockCommentEndTag {
			get { return "*/"; }
		}

		public bool IsSourceCodeFile (FilePath fileName)
		{
			return StringComparer.OrdinalIgnoreCase.Equals (Path.GetExtension (fileName), ".ts");
		}

		public FilePath GetFileName (FilePath fileNameWithoutExtension)
		{
			return fileNameWithoutExtension + ".ts";
		}
	}
}

