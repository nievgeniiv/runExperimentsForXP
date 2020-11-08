// Static Model


#ifndef __IPAIR__
#define __IPAIR__


namespace VsCoreLib
{
	
  class IPair
	{
	public:
		virtual unsigned int __stdcall GetID() const=0;
		virtual const wchar_t* __stdcall GetName() const=0;
	};// END INTERFACE DEFINITION IPair

} // VsCoreLib


#endif // __IPAIR__
