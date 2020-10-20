namespace Hjg.Pngcs
{
	internal enum FilterType
	{
		FILTER_NONE = 0,
		FILTER_SUB = 1,
		FILTER_UP = 2,
		FILTER_AVERAGE = 3,
		FILTER_PAETH = 4,
		FILTER_DEFAULT = -1,
		FILTER_AGGRESSIVE = -2,
		FILTER_VERYAGGRESSIVE = -3,
		FILTER_CYCLIC = -50,
		FILTER_UNKNOWN = -100
	}
}