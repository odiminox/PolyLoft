cmake_minimum_required(VERSION 2.8)

add_executable(%PROJECTNAME% ${%PROJECTNAME%_SRC})

# find and link gtest libraries
find_package(GTest REQUIRED)
include_directories(${GTEST_INCLUDE_DIRS})
target_link_libraries(%PROJECTNAME% ${GTEST_LIBRARY_DEBUG} ${GTEST_MAIN_LIBRARY_DEBUG})
