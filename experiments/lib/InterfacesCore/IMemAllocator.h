/**
IMemAllocator.h
**/

#ifndef __IMEMALLOCATOR_H__
#define __IMEMALLOCATOR_H__

#include "IMemBlock.h"

namespace VsCoreLib
{

  class IMemAllocator
  {
  public:
    virtual IMemBlock* GetMemBlock(unsigned int memBlockSize)=0;
  };

}

#endif // __IMEMALLOCATOR_H__