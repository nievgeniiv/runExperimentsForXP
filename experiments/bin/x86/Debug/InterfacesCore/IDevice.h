#ifndef __IDEVICE__
#define __IDEVICE__

#include "ISettingIterator.h"
#include "IFrameBuffer.h"

namespace VsCoreLib
{

  class IDevice
	{
	public:

    virtual IFrameBuffer* __stdcall Open() { return 0; }
    virtual void __stdcall Close() = 0;

	  virtual ISettingIterator* __stdcall GetSettings() { return 0; }
  	virtual ISetting* __stdcall GetSetting(int id) { return 0; }
    virtual IFrameBuffer* __stdcall GetFrameBuffer() { return 0; }

    virtual void __stdcall Run() = 0;
    virtual void __stdcall Stop() = 0;

    virtual void __stdcall SoftSync() = 0;

	};

} 

#endif