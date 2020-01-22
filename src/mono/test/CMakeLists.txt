cmake_minimum_required(VERSION 2.8)

add_executable(MONO ${MONO_SRC})

# find and link gtest libraries
find_package(GTest REQUIRED)
include_directories(${GTEST_INCLUDE_DIRS})
target_link_libraries(MONO ${GTEST_LIBRARY_DEBUG} ${GTEST_MAIN_LIBRARY_DEBUG})
