// Static Model


#ifndef __ITERATOR__
#define __ITERATOR__


namespace VsCoreLib
{
	
	template <typename T1, typename T2> class Iterator
	{
	private:
		T1& cont;
		const unsigned int contSize;
		unsigned int pos;

  public:
    Iterator(T1& initCont);

  public:
		void __stdcall Reset();
		bool __stdcall End() const;
		void __stdcall Next();
		T2& __stdcall GetCurrent();
	};// END CLASS DEFINITION Iterator

} // VsCoreLib

namespace VsCoreLib
{

  template <typename T1, typename T2> Iterator<T1, T2>::Iterator(T1& initCont)
    : cont(initCont)
		, contSize(cont.GetSize())
		, pos(0)
  {
  }

	template <typename T1, typename T2> void Iterator<T1, T2>::Reset()
	{
    pos = 0;
	}

	template <typename T1, typename T2> bool Iterator<T1, T2>::End() const
	{
    return pos >= contSize;
	}

	template <typename T1, typename T2> void Iterator<T1, T2>::Next()
	{
    ++pos;
	}

	template <typename T1, typename T2> T2& Iterator<T1, T2>::GetCurrent()
	{
    return cont.GetItem(pos);
	}

} // VsCoreLib


#endif // __ITERATOR__
