// Static Model


#ifndef __IENVIRONMENT__
#define __IENVIRONMENT__


// Include files
#include "IDeviceCreator.h"
#include "IPair.h"
#include "IPairIterator.h"
namespace VsCoreLib
{
	class IEnvironment
	{

	public:

		virtual IPairIterator* __stdcall GetDevicePrototypes()=0;

		virtual IDeviceCreator* __stdcall GetDeviceCreator(IPair* proto)=0;

	};// END INTERFACE DEFINITION IEnvironment
} // VsCoreLib


#endif // __IENVIRONMENT__
