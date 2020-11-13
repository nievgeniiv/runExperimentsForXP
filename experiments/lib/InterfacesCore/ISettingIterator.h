// Static Model


#ifndef __ISETTINGITERATOR__
#define __ISETTINGITERATOR__


// Include files
#include "ISetting.h"

namespace VsCoreLib
{

	class ISettingIterator
	{
	public:
		virtual void __stdcall Reset()=0;
		virtual bool __stdcall End() const=0;
		virtual void __stdcall Next()=0;
		virtual void __stdcall Free()=0;
		virtual ISetting* __stdcall GetCurrent()=0;
	};// END INTERFACE DEFINITION ISettingIterator

} // VsCoreLib


#endif // __ISETTINGITERATOR__
