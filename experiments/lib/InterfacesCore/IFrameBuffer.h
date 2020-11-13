#pragma once

#include "../InterfacesCore/ISettingIterator.h"
#include "../InterfacesCore/IFrame.h"
#include "../InterfacesCore/IFrameBufferObserver.h"

namespace VsCoreLib {

  class IFrameBuffer
  {
  public:
    virtual VsCoreLib::ISettingIterator* __stdcall GetSettings()=0;
	  virtual IFrame* __stdcall GetNextFrame()=0;
    virtual void __stdcall RegisterObserver(IFrameBufferObserver* obs)=0;
    virtual void __stdcall UnregisterObserver(IFrameBufferObserver* obs)=0;
  };

};