/**
IFrame.h
**/

#ifndef __IFRAME_H__
#define __IFRAME_H__

#include "ISettingIterator.h"

namespace VsCoreLib 
{

  class IFrame
  {
  public:
    virtual ISettingIterator* __stdcall GetSettings()=0;
    virtual const char* __stdcall GetFrameBuffer() const=0;
    virtual bool __stdcall SetFree()=0;
    virtual void __stdcall GetDimensions(LONG* pWidth, LONG* pHeight, LONG* pBits)=0;
		virtual void __stdcall SetEvenOdd(LONG Val)=0;
		virtual unsigned int __stdcall GetEvenOdd()=0;
  };

};

#endif // __IFRAME_H__