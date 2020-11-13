#pragma once

namespace VsCoreLib
{

	class ISettingString
	{
	public:
		virtual const wchar_t* __stdcall GetValue() const=0;
	};

}
