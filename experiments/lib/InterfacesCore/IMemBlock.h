/**
IMemBlock.h
**/

#ifndef __IMEMBLOCK_H__
#define __IMEMBLOCK_H__

namespace VsCoreLib
{

  class IMemBlock
  {
  public:
    virtual void Resize(unsigned int newSize)=0;
    virtual unsigned int GetSize() const=0;
    virtual char* GetBuffer()=0;
    virtual bool SetBusy()=0;
  };

}

#endif // __IMEMBLOCK_H__