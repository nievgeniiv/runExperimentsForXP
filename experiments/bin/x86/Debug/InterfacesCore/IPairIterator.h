// Static Model


#ifndef __IPAIRITERATOR__
#define __IPAIRITERATOR__


// Include files
#include "IPair.h"
namespace VsCoreLib
{
	class IPairIterator
	{

	public:

		virtual void __stdcall Reset()=0;

		virtual bool __stdcall End() const=0;

		virtual void __stdcall Next()=0;

		virtual void __stdcall Free()=0;

		virtual IPair* __stdcall GetCurrent()=0;

	};// END INTERFACE DEFINITION IPairIterator
} // VsCoreLib


#endif // __IPAIRITERATOR__
