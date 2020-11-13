// Static Model


#ifndef __CONTAINER__
#define __CONTAINER__

#include <vector>

namespace VsCoreLib
{

	template <typename T> class Container
	{
    std::vector<T> cont; 

	public:
		void Clear();
		void Add(T item);
		unsigned int GetSize() const;
		T& GetItem(unsigned int ind);

	};// END CLASS DEFINITION Container

} // VsCoreLib

namespace VsCoreLib
{

	template <typename T> void Container<T>::Clear()
	{
		cont.clear();
	}

	template <typename T> void Container<T>::Add(T item)
	{
		cont.push_back(item);
	}

	template <typename T> unsigned int Container<T>::GetSize() const
	{
		return cont.size();
	}

	template <typename T> T& Container<T>::GetItem(unsigned int ind)
	{
		return cont.at(ind);
	}

} // VsCoreLib


#endif // __CONTAINER__
