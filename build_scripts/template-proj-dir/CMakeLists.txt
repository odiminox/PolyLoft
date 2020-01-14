cmake_minimum_required(VERSION 2.6)

project (%PROJECTNAME%)
 
set (PROJECT_INCLUDE_DIR ${PROJECT_SOURCE_DIR}/include)
set (PROJECT_SOURCE_DIR ${CMAKE_CURRENT_SOURCE_DIR}/src)
 
file(GLOB_RECURSE %PROJECTNAME%_SRC ${PROJECT_SOURCE_DIR}/*.cpp)
 
include_directories("${PROJECT_INCLUDE_DIR}")
include_directories("${PROJECT_BINARY_DIR}")
 
add_library(${PROJECT_NAME} SHARED ${%PROJECTNAME%_SRC})

add_subdirectory(test)
