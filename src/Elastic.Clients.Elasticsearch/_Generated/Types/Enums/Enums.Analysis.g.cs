// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information.
//
// ███╗   ██╗ ██████╗ ████████╗██╗ ██████╗███████╗
// ████╗  ██║██╔═══██╗╚══██╔══╝██║██╔════╝██╔════╝
// ██╔██╗ ██║██║   ██║   ██║   ██║██║     █████╗
// ██║╚██╗██║██║   ██║   ██║   ██║██║     ██╔══╝
// ██║ ╚████║╚██████╔╝   ██║   ██║╚██████╗███████╗
// ╚═╝  ╚═══╝ ╚═════╝    ╚═╝   ╚═╝ ╚═════╝╚══════╝
// ------------------------------------------------
//
// This file is automatically generated.
// Please do not edit these files manually.
//
// ------------------------------------------------

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using Elastic.Transport;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Analysis
{
	[JsonConverter(typeof(DelimitedPayloadEncodingConverter))]
	public enum DelimitedPayloadEncoding
	{
		Integer,
		Identity,
		Float
	}

	internal sealed class DelimitedPayloadEncodingConverter : JsonConverter<DelimitedPayloadEncoding>
	{
		public override DelimitedPayloadEncoding Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			var enumString = reader.GetString();
			switch (enumString)
			{
				case "int":
					return DelimitedPayloadEncoding.Integer;
				case "identity":
					return DelimitedPayloadEncoding.Identity;
				case "float":
					return DelimitedPayloadEncoding.Float;
			}

			ThrowHelper.ThrowJsonException();
			return default;
		}

		public override void Write(Utf8JsonWriter writer, DelimitedPayloadEncoding value, JsonSerializerOptions options)
		{
			switch (value)
			{
				case DelimitedPayloadEncoding.Integer:
					writer.WriteStringValue("int");
					return;
				case DelimitedPayloadEncoding.Identity:
					writer.WriteStringValue("identity");
					return;
				case DelimitedPayloadEncoding.Float:
					writer.WriteStringValue("float");
					return;
			}

			writer.WriteNullValue();
		}
	}

	[JsonConverter(typeof(EdgeNGramSideConverter))]
	public enum EdgeNGramSide
	{
		Front,
		Back
	}

	internal sealed class EdgeNGramSideConverter : JsonConverter<EdgeNGramSide>
	{
		public override EdgeNGramSide Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			var enumString = reader.GetString();
			switch (enumString)
			{
				case "front":
					return EdgeNGramSide.Front;
				case "back":
					return EdgeNGramSide.Back;
			}

			ThrowHelper.ThrowJsonException();
			return default;
		}

		public override void Write(Utf8JsonWriter writer, EdgeNGramSide value, JsonSerializerOptions options)
		{
			switch (value)
			{
				case EdgeNGramSide.Front:
					writer.WriteStringValue("front");
					return;
				case EdgeNGramSide.Back:
					writer.WriteStringValue("back");
					return;
			}

			writer.WriteNullValue();
		}
	}

	[JsonConverter(typeof(IcuCollationAlternateConverter))]
	public enum IcuCollationAlternate
	{
		Shifted,
		NonIgnorable
	}

	internal sealed class IcuCollationAlternateConverter : JsonConverter<IcuCollationAlternate>
	{
		public override IcuCollationAlternate Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			var enumString = reader.GetString();
			switch (enumString)
			{
				case "shifted":
					return IcuCollationAlternate.Shifted;
				case "non-ignorable":
					return IcuCollationAlternate.NonIgnorable;
			}

			ThrowHelper.ThrowJsonException();
			return default;
		}

		public override void Write(Utf8JsonWriter writer, IcuCollationAlternate value, JsonSerializerOptions options)
		{
			switch (value)
			{
				case IcuCollationAlternate.Shifted:
					writer.WriteStringValue("shifted");
					return;
				case IcuCollationAlternate.NonIgnorable:
					writer.WriteStringValue("non-ignorable");
					return;
			}

			writer.WriteNullValue();
		}
	}

	[JsonConverter(typeof(IcuCollationCaseFirstConverter))]
	public enum IcuCollationCaseFirst
	{
		Upper,
		Lower
	}

	internal sealed class IcuCollationCaseFirstConverter : JsonConverter<IcuCollationCaseFirst>
	{
		public override IcuCollationCaseFirst Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			var enumString = reader.GetString();
			switch (enumString)
			{
				case "upper":
					return IcuCollationCaseFirst.Upper;
				case "lower":
					return IcuCollationCaseFirst.Lower;
			}

			ThrowHelper.ThrowJsonException();
			return default;
		}

		public override void Write(Utf8JsonWriter writer, IcuCollationCaseFirst value, JsonSerializerOptions options)
		{
			switch (value)
			{
				case IcuCollationCaseFirst.Upper:
					writer.WriteStringValue("upper");
					return;
				case IcuCollationCaseFirst.Lower:
					writer.WriteStringValue("lower");
					return;
			}

			writer.WriteNullValue();
		}
	}

	[JsonConverter(typeof(IcuCollationDecompositionConverter))]
	public enum IcuCollationDecomposition
	{
		No,
		Identical
	}

	internal sealed class IcuCollationDecompositionConverter : JsonConverter<IcuCollationDecomposition>
	{
		public override IcuCollationDecomposition Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			var enumString = reader.GetString();
			switch (enumString)
			{
				case "no":
					return IcuCollationDecomposition.No;
				case "identical":
					return IcuCollationDecomposition.Identical;
			}

			ThrowHelper.ThrowJsonException();
			return default;
		}

		public override void Write(Utf8JsonWriter writer, IcuCollationDecomposition value, JsonSerializerOptions options)
		{
			switch (value)
			{
				case IcuCollationDecomposition.No:
					writer.WriteStringValue("no");
					return;
				case IcuCollationDecomposition.Identical:
					writer.WriteStringValue("identical");
					return;
			}

			writer.WriteNullValue();
		}
	}

	[JsonConverter(typeof(IcuCollationStrengthConverter))]
	public enum IcuCollationStrength
	{
		Tertiary,
		Secondary,
		Quaternary,
		Primary,
		Identical
	}

	internal sealed class IcuCollationStrengthConverter : JsonConverter<IcuCollationStrength>
	{
		public override IcuCollationStrength Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			var enumString = reader.GetString();
			switch (enumString)
			{
				case "tertiary":
					return IcuCollationStrength.Tertiary;
				case "secondary":
					return IcuCollationStrength.Secondary;
				case "quaternary":
					return IcuCollationStrength.Quaternary;
				case "primary":
					return IcuCollationStrength.Primary;
				case "identical":
					return IcuCollationStrength.Identical;
			}

			ThrowHelper.ThrowJsonException();
			return default;
		}

		public override void Write(Utf8JsonWriter writer, IcuCollationStrength value, JsonSerializerOptions options)
		{
			switch (value)
			{
				case IcuCollationStrength.Tertiary:
					writer.WriteStringValue("tertiary");
					return;
				case IcuCollationStrength.Secondary:
					writer.WriteStringValue("secondary");
					return;
				case IcuCollationStrength.Quaternary:
					writer.WriteStringValue("quaternary");
					return;
				case IcuCollationStrength.Primary:
					writer.WriteStringValue("primary");
					return;
				case IcuCollationStrength.Identical:
					writer.WriteStringValue("identical");
					return;
			}

			writer.WriteNullValue();
		}
	}

	[JsonConverter(typeof(IcuNormalizationModeConverter))]
	public enum IcuNormalizationMode
	{
		Decompose,
		Compose
	}

	internal sealed class IcuNormalizationModeConverter : JsonConverter<IcuNormalizationMode>
	{
		public override IcuNormalizationMode Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			var enumString = reader.GetString();
			switch (enumString)
			{
				case "decompose":
					return IcuNormalizationMode.Decompose;
				case "compose":
					return IcuNormalizationMode.Compose;
			}

			ThrowHelper.ThrowJsonException();
			return default;
		}

		public override void Write(Utf8JsonWriter writer, IcuNormalizationMode value, JsonSerializerOptions options)
		{
			switch (value)
			{
				case IcuNormalizationMode.Decompose:
					writer.WriteStringValue("decompose");
					return;
				case IcuNormalizationMode.Compose:
					writer.WriteStringValue("compose");
					return;
			}

			writer.WriteNullValue();
		}
	}

	[JsonConverter(typeof(IcuNormalizationTypeConverter))]
	public enum IcuNormalizationType
	{
		NfkcCf,
		Nfkc,
		Nfc
	}

	internal sealed class IcuNormalizationTypeConverter : JsonConverter<IcuNormalizationType>
	{
		public override IcuNormalizationType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			var enumString = reader.GetString();
			switch (enumString)
			{
				case "nfkc_cf":
					return IcuNormalizationType.NfkcCf;
				case "nfkc":
					return IcuNormalizationType.Nfkc;
				case "nfc":
					return IcuNormalizationType.Nfc;
			}

			ThrowHelper.ThrowJsonException();
			return default;
		}

		public override void Write(Utf8JsonWriter writer, IcuNormalizationType value, JsonSerializerOptions options)
		{
			switch (value)
			{
				case IcuNormalizationType.NfkcCf:
					writer.WriteStringValue("nfkc_cf");
					return;
				case IcuNormalizationType.Nfkc:
					writer.WriteStringValue("nfkc");
					return;
				case IcuNormalizationType.Nfc:
					writer.WriteStringValue("nfc");
					return;
			}

			writer.WriteNullValue();
		}
	}

	[JsonConverter(typeof(IcuTransformDirectionConverter))]
	public enum IcuTransformDirection
	{
		Reverse,
		Forward
	}

	internal sealed class IcuTransformDirectionConverter : JsonConverter<IcuTransformDirection>
	{
		public override IcuTransformDirection Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			var enumString = reader.GetString();
			switch (enumString)
			{
				case "reverse":
					return IcuTransformDirection.Reverse;
				case "forward":
					return IcuTransformDirection.Forward;
			}

			ThrowHelper.ThrowJsonException();
			return default;
		}

		public override void Write(Utf8JsonWriter writer, IcuTransformDirection value, JsonSerializerOptions options)
		{
			switch (value)
			{
				case IcuTransformDirection.Reverse:
					writer.WriteStringValue("reverse");
					return;
				case IcuTransformDirection.Forward:
					writer.WriteStringValue("forward");
					return;
			}

			writer.WriteNullValue();
		}
	}

	[JsonConverter(typeof(KeepTypesModeConverter))]
	public enum KeepTypesMode
	{
		Include,
		Exclude
	}

	internal sealed class KeepTypesModeConverter : JsonConverter<KeepTypesMode>
	{
		public override KeepTypesMode Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			var enumString = reader.GetString();
			switch (enumString)
			{
				case "include":
					return KeepTypesMode.Include;
				case "exclude":
					return KeepTypesMode.Exclude;
			}

			ThrowHelper.ThrowJsonException();
			return default;
		}

		public override void Write(Utf8JsonWriter writer, KeepTypesMode value, JsonSerializerOptions options)
		{
			switch (value)
			{
				case KeepTypesMode.Include:
					writer.WriteStringValue("include");
					return;
				case KeepTypesMode.Exclude:
					writer.WriteStringValue("exclude");
					return;
			}

			writer.WriteNullValue();
		}
	}

	[JsonConverter(typeof(KuromojiTokenizationModeConverter))]
	public enum KuromojiTokenizationMode
	{
		Search,
		Normal,
		Extended
	}

	internal sealed class KuromojiTokenizationModeConverter : JsonConverter<KuromojiTokenizationMode>
	{
		public override KuromojiTokenizationMode Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			var enumString = reader.GetString();
			switch (enumString)
			{
				case "search":
					return KuromojiTokenizationMode.Search;
				case "normal":
					return KuromojiTokenizationMode.Normal;
				case "extended":
					return KuromojiTokenizationMode.Extended;
			}

			ThrowHelper.ThrowJsonException();
			return default;
		}

		public override void Write(Utf8JsonWriter writer, KuromojiTokenizationMode value, JsonSerializerOptions options)
		{
			switch (value)
			{
				case KuromojiTokenizationMode.Search:
					writer.WriteStringValue("search");
					return;
				case KuromojiTokenizationMode.Normal:
					writer.WriteStringValue("normal");
					return;
				case KuromojiTokenizationMode.Extended:
					writer.WriteStringValue("extended");
					return;
			}

			writer.WriteNullValue();
		}
	}

	[JsonConverter(typeof(LanguageConverter))]
	public enum Language
	{
		Turkish,
		Thai,
		Swedish,
		Spanish,
		Sorani,
		Russian,
		Romanian,
		Portuguese,
		Persian,
		Norwegian,
		Latvian,
		Italian,
		Irish,
		Indonesian,
		Hungarian,
		Hindi,
		Greek,
		German,
		Galician,
		French,
		Finnish,
		Estonian,
		English,
		Dutch,
		Danish,
		Czech,
		Cjk,
		Chinese,
		Catalan,
		Bulgarian,
		Brazilian,
		Basque,
		Armenian,
		Arabic
	}

	internal sealed class LanguageConverter : JsonConverter<Language>
	{
		public override Language Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			var enumString = reader.GetString();
			switch (enumString)
			{
				case "Turkish":
					return Language.Turkish;
				case "Thai":
					return Language.Thai;
				case "Swedish":
					return Language.Swedish;
				case "Spanish":
					return Language.Spanish;
				case "Sorani":
					return Language.Sorani;
				case "Russian":
					return Language.Russian;
				case "Romanian":
					return Language.Romanian;
				case "Portuguese":
					return Language.Portuguese;
				case "Persian":
					return Language.Persian;
				case "Norwegian":
					return Language.Norwegian;
				case "Latvian":
					return Language.Latvian;
				case "Italian":
					return Language.Italian;
				case "Irish":
					return Language.Irish;
				case "Indonesian":
					return Language.Indonesian;
				case "Hungarian":
					return Language.Hungarian;
				case "Hindi":
					return Language.Hindi;
				case "Greek":
					return Language.Greek;
				case "German":
					return Language.German;
				case "Galician":
					return Language.Galician;
				case "French":
					return Language.French;
				case "Finnish":
					return Language.Finnish;
				case "Estonian":
					return Language.Estonian;
				case "English":
					return Language.English;
				case "Dutch":
					return Language.Dutch;
				case "Danish":
					return Language.Danish;
				case "Czech":
					return Language.Czech;
				case "Cjk":
					return Language.Cjk;
				case "Chinese":
					return Language.Chinese;
				case "Catalan":
					return Language.Catalan;
				case "Bulgarian":
					return Language.Bulgarian;
				case "Brazilian":
					return Language.Brazilian;
				case "Basque":
					return Language.Basque;
				case "Armenian":
					return Language.Armenian;
				case "Arabic":
					return Language.Arabic;
			}

			ThrowHelper.ThrowJsonException();
			return default;
		}

		public override void Write(Utf8JsonWriter writer, Language value, JsonSerializerOptions options)
		{
			switch (value)
			{
				case Language.Turkish:
					writer.WriteStringValue("Turkish");
					return;
				case Language.Thai:
					writer.WriteStringValue("Thai");
					return;
				case Language.Swedish:
					writer.WriteStringValue("Swedish");
					return;
				case Language.Spanish:
					writer.WriteStringValue("Spanish");
					return;
				case Language.Sorani:
					writer.WriteStringValue("Sorani");
					return;
				case Language.Russian:
					writer.WriteStringValue("Russian");
					return;
				case Language.Romanian:
					writer.WriteStringValue("Romanian");
					return;
				case Language.Portuguese:
					writer.WriteStringValue("Portuguese");
					return;
				case Language.Persian:
					writer.WriteStringValue("Persian");
					return;
				case Language.Norwegian:
					writer.WriteStringValue("Norwegian");
					return;
				case Language.Latvian:
					writer.WriteStringValue("Latvian");
					return;
				case Language.Italian:
					writer.WriteStringValue("Italian");
					return;
				case Language.Irish:
					writer.WriteStringValue("Irish");
					return;
				case Language.Indonesian:
					writer.WriteStringValue("Indonesian");
					return;
				case Language.Hungarian:
					writer.WriteStringValue("Hungarian");
					return;
				case Language.Hindi:
					writer.WriteStringValue("Hindi");
					return;
				case Language.Greek:
					writer.WriteStringValue("Greek");
					return;
				case Language.German:
					writer.WriteStringValue("German");
					return;
				case Language.Galician:
					writer.WriteStringValue("Galician");
					return;
				case Language.French:
					writer.WriteStringValue("French");
					return;
				case Language.Finnish:
					writer.WriteStringValue("Finnish");
					return;
				case Language.Estonian:
					writer.WriteStringValue("Estonian");
					return;
				case Language.English:
					writer.WriteStringValue("English");
					return;
				case Language.Dutch:
					writer.WriteStringValue("Dutch");
					return;
				case Language.Danish:
					writer.WriteStringValue("Danish");
					return;
				case Language.Czech:
					writer.WriteStringValue("Czech");
					return;
				case Language.Cjk:
					writer.WriteStringValue("Cjk");
					return;
				case Language.Chinese:
					writer.WriteStringValue("Chinese");
					return;
				case Language.Catalan:
					writer.WriteStringValue("Catalan");
					return;
				case Language.Bulgarian:
					writer.WriteStringValue("Bulgarian");
					return;
				case Language.Brazilian:
					writer.WriteStringValue("Brazilian");
					return;
				case Language.Basque:
					writer.WriteStringValue("Basque");
					return;
				case Language.Armenian:
					writer.WriteStringValue("Armenian");
					return;
				case Language.Arabic:
					writer.WriteStringValue("Arabic");
					return;
			}

			writer.WriteNullValue();
		}
	}

	[JsonConverter(typeof(NoriDecompoundModeConverter))]
	public enum NoriDecompoundMode
	{
		None,
		Mixed,
		Discard
	}

	internal sealed class NoriDecompoundModeConverter : JsonConverter<NoriDecompoundMode>
	{
		public override NoriDecompoundMode Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			var enumString = reader.GetString();
			switch (enumString)
			{
				case "none":
					return NoriDecompoundMode.None;
				case "mixed":
					return NoriDecompoundMode.Mixed;
				case "discard":
					return NoriDecompoundMode.Discard;
			}

			ThrowHelper.ThrowJsonException();
			return default;
		}

		public override void Write(Utf8JsonWriter writer, NoriDecompoundMode value, JsonSerializerOptions options)
		{
			switch (value)
			{
				case NoriDecompoundMode.None:
					writer.WriteStringValue("none");
					return;
				case NoriDecompoundMode.Mixed:
					writer.WriteStringValue("mixed");
					return;
				case NoriDecompoundMode.Discard:
					writer.WriteStringValue("discard");
					return;
			}

			writer.WriteNullValue();
		}
	}

	[JsonConverter(typeof(PhoneticEncoderConverter))]
	public enum PhoneticEncoder
	{
		Soundex,
		RefinedSoundex,
		Nysiis,
		Metaphone,
		Koelnerphonetik,
		Haasephonetik,
		DoubleMetaphone,
		DaitchMokotoff,
		Cologne,
		Caverphone2,
		Caverphone1,
		BeiderMorse
	}

	internal sealed class PhoneticEncoderConverter : JsonConverter<PhoneticEncoder>
	{
		public override PhoneticEncoder Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			var enumString = reader.GetString();
			switch (enumString)
			{
				case "soundex":
					return PhoneticEncoder.Soundex;
				case "refined_soundex":
					return PhoneticEncoder.RefinedSoundex;
				case "nysiis":
					return PhoneticEncoder.Nysiis;
				case "metaphone":
					return PhoneticEncoder.Metaphone;
				case "koelnerphonetik":
					return PhoneticEncoder.Koelnerphonetik;
				case "haasephonetik":
					return PhoneticEncoder.Haasephonetik;
				case "double_metaphone":
					return PhoneticEncoder.DoubleMetaphone;
				case "daitch_mokotoff":
					return PhoneticEncoder.DaitchMokotoff;
				case "cologne":
					return PhoneticEncoder.Cologne;
				case "caverphone2":
					return PhoneticEncoder.Caverphone2;
				case "caverphone1":
					return PhoneticEncoder.Caverphone1;
				case "beider_morse":
					return PhoneticEncoder.BeiderMorse;
			}

			ThrowHelper.ThrowJsonException();
			return default;
		}

		public override void Write(Utf8JsonWriter writer, PhoneticEncoder value, JsonSerializerOptions options)
		{
			switch (value)
			{
				case PhoneticEncoder.Soundex:
					writer.WriteStringValue("soundex");
					return;
				case PhoneticEncoder.RefinedSoundex:
					writer.WriteStringValue("refined_soundex");
					return;
				case PhoneticEncoder.Nysiis:
					writer.WriteStringValue("nysiis");
					return;
				case PhoneticEncoder.Metaphone:
					writer.WriteStringValue("metaphone");
					return;
				case PhoneticEncoder.Koelnerphonetik:
					writer.WriteStringValue("koelnerphonetik");
					return;
				case PhoneticEncoder.Haasephonetik:
					writer.WriteStringValue("haasephonetik");
					return;
				case PhoneticEncoder.DoubleMetaphone:
					writer.WriteStringValue("double_metaphone");
					return;
				case PhoneticEncoder.DaitchMokotoff:
					writer.WriteStringValue("daitch_mokotoff");
					return;
				case PhoneticEncoder.Cologne:
					writer.WriteStringValue("cologne");
					return;
				case PhoneticEncoder.Caverphone2:
					writer.WriteStringValue("caverphone2");
					return;
				case PhoneticEncoder.Caverphone1:
					writer.WriteStringValue("caverphone1");
					return;
				case PhoneticEncoder.BeiderMorse:
					writer.WriteStringValue("beider_morse");
					return;
			}

			writer.WriteNullValue();
		}
	}

	[JsonConverter(typeof(PhoneticLanguageConverter))]
	public enum PhoneticLanguage
	{
		Spanish,
		Russian,
		Romanian,
		Polish,
		Hungarian,
		Hebrew,
		German,
		French,
		English,
		Cyrillic,
		Common,
		Any
	}

	internal sealed class PhoneticLanguageConverter : JsonConverter<PhoneticLanguage>
	{
		public override PhoneticLanguage Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			var enumString = reader.GetString();
			switch (enumString)
			{
				case "spanish":
					return PhoneticLanguage.Spanish;
				case "russian":
					return PhoneticLanguage.Russian;
				case "romanian":
					return PhoneticLanguage.Romanian;
				case "polish":
					return PhoneticLanguage.Polish;
				case "hungarian":
					return PhoneticLanguage.Hungarian;
				case "hebrew":
					return PhoneticLanguage.Hebrew;
				case "german":
					return PhoneticLanguage.German;
				case "french":
					return PhoneticLanguage.French;
				case "english":
					return PhoneticLanguage.English;
				case "cyrillic":
					return PhoneticLanguage.Cyrillic;
				case "common":
					return PhoneticLanguage.Common;
				case "any":
					return PhoneticLanguage.Any;
			}

			ThrowHelper.ThrowJsonException();
			return default;
		}

		public override void Write(Utf8JsonWriter writer, PhoneticLanguage value, JsonSerializerOptions options)
		{
			switch (value)
			{
				case PhoneticLanguage.Spanish:
					writer.WriteStringValue("spanish");
					return;
				case PhoneticLanguage.Russian:
					writer.WriteStringValue("russian");
					return;
				case PhoneticLanguage.Romanian:
					writer.WriteStringValue("romanian");
					return;
				case PhoneticLanguage.Polish:
					writer.WriteStringValue("polish");
					return;
				case PhoneticLanguage.Hungarian:
					writer.WriteStringValue("hungarian");
					return;
				case PhoneticLanguage.Hebrew:
					writer.WriteStringValue("hebrew");
					return;
				case PhoneticLanguage.German:
					writer.WriteStringValue("german");
					return;
				case PhoneticLanguage.French:
					writer.WriteStringValue("french");
					return;
				case PhoneticLanguage.English:
					writer.WriteStringValue("english");
					return;
				case PhoneticLanguage.Cyrillic:
					writer.WriteStringValue("cyrillic");
					return;
				case PhoneticLanguage.Common:
					writer.WriteStringValue("common");
					return;
				case PhoneticLanguage.Any:
					writer.WriteStringValue("any");
					return;
			}

			writer.WriteNullValue();
		}
	}

	[JsonConverter(typeof(PhoneticNameTypeConverter))]
	public enum PhoneticNameType
	{
		Sephardic,
		Generic,
		Ashkenazi
	}

	internal sealed class PhoneticNameTypeConverter : JsonConverter<PhoneticNameType>
	{
		public override PhoneticNameType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			var enumString = reader.GetString();
			switch (enumString)
			{
				case "sephardic":
					return PhoneticNameType.Sephardic;
				case "generic":
					return PhoneticNameType.Generic;
				case "ashkenazi":
					return PhoneticNameType.Ashkenazi;
			}

			ThrowHelper.ThrowJsonException();
			return default;
		}

		public override void Write(Utf8JsonWriter writer, PhoneticNameType value, JsonSerializerOptions options)
		{
			switch (value)
			{
				case PhoneticNameType.Sephardic:
					writer.WriteStringValue("sephardic");
					return;
				case PhoneticNameType.Generic:
					writer.WriteStringValue("generic");
					return;
				case PhoneticNameType.Ashkenazi:
					writer.WriteStringValue("ashkenazi");
					return;
			}

			writer.WriteNullValue();
		}
	}

	[JsonConverter(typeof(PhoneticRuleTypeConverter))]
	public enum PhoneticRuleType
	{
		Exact,
		Approx
	}

	internal sealed class PhoneticRuleTypeConverter : JsonConverter<PhoneticRuleType>
	{
		public override PhoneticRuleType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			var enumString = reader.GetString();
			switch (enumString)
			{
				case "exact":
					return PhoneticRuleType.Exact;
				case "approx":
					return PhoneticRuleType.Approx;
			}

			ThrowHelper.ThrowJsonException();
			return default;
		}

		public override void Write(Utf8JsonWriter writer, PhoneticRuleType value, JsonSerializerOptions options)
		{
			switch (value)
			{
				case PhoneticRuleType.Exact:
					writer.WriteStringValue("exact");
					return;
				case PhoneticRuleType.Approx:
					writer.WriteStringValue("approx");
					return;
			}

			writer.WriteNullValue();
		}
	}

	[JsonConverter(typeof(SnowballLanguageConverter))]
	public enum SnowballLanguage
	{
		Turkish,
		Swedish,
		Spanish,
		Russian,
		Romanian,
		Portuguese,
		Porter,
		Norwegian,
		Lovins,
		Kp,
		Italian,
		Hungarian,
		German2,
		German,
		French,
		Finnish,
		English,
		Dutch,
		Danish,
		Catalan,
		Basque,
		Armenian
	}

	internal sealed class SnowballLanguageConverter : JsonConverter<SnowballLanguage>
	{
		public override SnowballLanguage Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			var enumString = reader.GetString();
			switch (enumString)
			{
				case "Turkish":
					return SnowballLanguage.Turkish;
				case "Swedish":
					return SnowballLanguage.Swedish;
				case "Spanish":
					return SnowballLanguage.Spanish;
				case "Russian":
					return SnowballLanguage.Russian;
				case "Romanian":
					return SnowballLanguage.Romanian;
				case "Portuguese":
					return SnowballLanguage.Portuguese;
				case "Porter":
					return SnowballLanguage.Porter;
				case "Norwegian":
					return SnowballLanguage.Norwegian;
				case "Lovins":
					return SnowballLanguage.Lovins;
				case "Kp":
					return SnowballLanguage.Kp;
				case "Italian":
					return SnowballLanguage.Italian;
				case "Hungarian":
					return SnowballLanguage.Hungarian;
				case "German2":
					return SnowballLanguage.German2;
				case "German":
					return SnowballLanguage.German;
				case "French":
					return SnowballLanguage.French;
				case "Finnish":
					return SnowballLanguage.Finnish;
				case "English":
					return SnowballLanguage.English;
				case "Dutch":
					return SnowballLanguage.Dutch;
				case "Danish":
					return SnowballLanguage.Danish;
				case "Catalan":
					return SnowballLanguage.Catalan;
				case "Basque":
					return SnowballLanguage.Basque;
				case "Armenian":
					return SnowballLanguage.Armenian;
			}

			ThrowHelper.ThrowJsonException();
			return default;
		}

		public override void Write(Utf8JsonWriter writer, SnowballLanguage value, JsonSerializerOptions options)
		{
			switch (value)
			{
				case SnowballLanguage.Turkish:
					writer.WriteStringValue("Turkish");
					return;
				case SnowballLanguage.Swedish:
					writer.WriteStringValue("Swedish");
					return;
				case SnowballLanguage.Spanish:
					writer.WriteStringValue("Spanish");
					return;
				case SnowballLanguage.Russian:
					writer.WriteStringValue("Russian");
					return;
				case SnowballLanguage.Romanian:
					writer.WriteStringValue("Romanian");
					return;
				case SnowballLanguage.Portuguese:
					writer.WriteStringValue("Portuguese");
					return;
				case SnowballLanguage.Porter:
					writer.WriteStringValue("Porter");
					return;
				case SnowballLanguage.Norwegian:
					writer.WriteStringValue("Norwegian");
					return;
				case SnowballLanguage.Lovins:
					writer.WriteStringValue("Lovins");
					return;
				case SnowballLanguage.Kp:
					writer.WriteStringValue("Kp");
					return;
				case SnowballLanguage.Italian:
					writer.WriteStringValue("Italian");
					return;
				case SnowballLanguage.Hungarian:
					writer.WriteStringValue("Hungarian");
					return;
				case SnowballLanguage.German2:
					writer.WriteStringValue("German2");
					return;
				case SnowballLanguage.German:
					writer.WriteStringValue("German");
					return;
				case SnowballLanguage.French:
					writer.WriteStringValue("French");
					return;
				case SnowballLanguage.Finnish:
					writer.WriteStringValue("Finnish");
					return;
				case SnowballLanguage.English:
					writer.WriteStringValue("English");
					return;
				case SnowballLanguage.Dutch:
					writer.WriteStringValue("Dutch");
					return;
				case SnowballLanguage.Danish:
					writer.WriteStringValue("Danish");
					return;
				case SnowballLanguage.Catalan:
					writer.WriteStringValue("Catalan");
					return;
				case SnowballLanguage.Basque:
					writer.WriteStringValue("Basque");
					return;
				case SnowballLanguage.Armenian:
					writer.WriteStringValue("Armenian");
					return;
			}

			writer.WriteNullValue();
		}
	}

	[JsonConverter(typeof(SynonymFormatConverter))]
	public enum SynonymFormat
	{
		Wordnet,
		Solr
	}

	internal sealed class SynonymFormatConverter : JsonConverter<SynonymFormat>
	{
		public override SynonymFormat Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			var enumString = reader.GetString();
			switch (enumString)
			{
				case "wordnet":
					return SynonymFormat.Wordnet;
				case "solr":
					return SynonymFormat.Solr;
			}

			ThrowHelper.ThrowJsonException();
			return default;
		}

		public override void Write(Utf8JsonWriter writer, SynonymFormat value, JsonSerializerOptions options)
		{
			switch (value)
			{
				case SynonymFormat.Wordnet:
					writer.WriteStringValue("wordnet");
					return;
				case SynonymFormat.Solr:
					writer.WriteStringValue("solr");
					return;
			}

			writer.WriteNullValue();
		}
	}

	[JsonConverter(typeof(TokenCharConverter))]
	public enum TokenChar
	{
		Whitespace,
		Symbol,
		Punctuation,
		Letter,
		Digit,
		Custom
	}

	internal sealed class TokenCharConverter : JsonConverter<TokenChar>
	{
		public override TokenChar Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			var enumString = reader.GetString();
			switch (enumString)
			{
				case "whitespace":
					return TokenChar.Whitespace;
				case "symbol":
					return TokenChar.Symbol;
				case "punctuation":
					return TokenChar.Punctuation;
				case "letter":
					return TokenChar.Letter;
				case "digit":
					return TokenChar.Digit;
				case "custom":
					return TokenChar.Custom;
			}

			ThrowHelper.ThrowJsonException();
			return default;
		}

		public override void Write(Utf8JsonWriter writer, TokenChar value, JsonSerializerOptions options)
		{
			switch (value)
			{
				case TokenChar.Whitespace:
					writer.WriteStringValue("whitespace");
					return;
				case TokenChar.Symbol:
					writer.WriteStringValue("symbol");
					return;
				case TokenChar.Punctuation:
					writer.WriteStringValue("punctuation");
					return;
				case TokenChar.Letter:
					writer.WriteStringValue("letter");
					return;
				case TokenChar.Digit:
					writer.WriteStringValue("digit");
					return;
				case TokenChar.Custom:
					writer.WriteStringValue("custom");
					return;
			}

			writer.WriteNullValue();
		}
	}
}