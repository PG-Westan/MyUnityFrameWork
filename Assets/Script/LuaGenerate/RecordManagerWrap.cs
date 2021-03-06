﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class RecordManagerWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(RecordManager), typeof(System.Object));
		L.RegFunction("GetData", GetData);
		L.RegFunction("SaveData", SaveData);
		L.RegFunction("CleanRecord", CleanRecord);
		L.RegFunction("CleanAllRecord", CleanAllRecord);
		L.RegFunction("CleanCatch", CleanCatch);
		L.RegFunction("SaveRecord", SaveRecord);
		L.RegFunction("New", _CreateRecordManager);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("c_directoryName", get_c_directoryName, null);
		L.RegVar("c_expandName", get_c_expandName, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateRecordManager(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				RecordManager obj = new RecordManager();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: RecordManager.New");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetData(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			string arg0 = ToLua.CheckString(L, 1);
			RecordTable o = RecordManager.GetData(arg0);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SaveData(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			string arg0 = ToLua.CheckString(L, 1);
			RecordTable arg1 = (RecordTable)ToLua.CheckObject(L, 2, typeof(RecordTable));
			RecordManager.SaveData(arg0, arg1);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CleanRecord(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			string arg0 = ToLua.CheckString(L, 1);
			RecordManager.CleanRecord(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CleanAllRecord(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			RecordManager.CleanAllRecord();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CleanCatch(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			RecordManager.CleanCatch();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SaveRecord(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 3 && TypeChecker.CheckTypes(L, 1, typeof(string), typeof(string), typeof(UnityEngine.Vector2)))
			{
				string arg0 = ToLua.ToString(L, 1);
				string arg1 = ToLua.ToString(L, 2);
				UnityEngine.Vector2 arg2 = (UnityEngine.Vector2)ToLua.ToObject(L, 3);
				RecordManager.SaveRecord(arg0, arg1, arg2);
				return 0;
			}
			else if (count == 3 && TypeChecker.CheckTypes(L, 1, typeof(string), typeof(string), typeof(UnityEngine.Vector3)))
			{
				string arg0 = ToLua.ToString(L, 1);
				string arg1 = ToLua.ToString(L, 2);
				UnityEngine.Vector3 arg2 = (UnityEngine.Vector3)ToLua.ToObject(L, 3);
				RecordManager.SaveRecord(arg0, arg1, arg2);
				return 0;
			}
			else if (count == 3 && TypeChecker.CheckTypes(L, 1, typeof(string), typeof(string), typeof(UnityEngine.Color)))
			{
				string arg0 = ToLua.ToString(L, 1);
				string arg1 = ToLua.ToString(L, 2);
				UnityEngine.Color arg2 = (UnityEngine.Color)ToLua.ToObject(L, 3);
				RecordManager.SaveRecord(arg0, arg1, arg2);
				return 0;
			}
			else if (count == 3 && TypeChecker.CheckTypes(L, 1, typeof(string), typeof(string), typeof(string)))
			{
				string arg0 = ToLua.ToString(L, 1);
				string arg1 = ToLua.ToString(L, 2);
				string arg2 = ToLua.ToString(L, 3);
				RecordManager.SaveRecord(arg0, arg1, arg2);
				return 0;
			}
			else if (count == 3 && TypeChecker.CheckTypes(L, 1, typeof(string), typeof(string), typeof(bool)))
			{
				string arg0 = ToLua.ToString(L, 1);
				string arg1 = ToLua.ToString(L, 2);
				bool arg2 = LuaDLL.lua_toboolean(L, 3);
				RecordManager.SaveRecord(arg0, arg1, arg2);
				return 0;
			}
			else if (count == 3 && TypeChecker.CheckTypes(L, 1, typeof(string), typeof(string), typeof(float)))
			{
				string arg0 = ToLua.ToString(L, 1);
				string arg1 = ToLua.ToString(L, 2);
				float arg2 = (float)LuaDLL.lua_tonumber(L, 3);
				RecordManager.SaveRecord(arg0, arg1, arg2);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: RecordManager.SaveRecord");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_c_directoryName(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, RecordManager.c_directoryName);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_c_expandName(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, RecordManager.c_expandName);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

