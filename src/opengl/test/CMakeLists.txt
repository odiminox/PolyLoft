cmake_minimum_required(VERSION 2.8)

add_executable(OPENGL ${OPENGL_SRC})

# find and link gtest libraries
find_package(GTest REQUIRED)
include_directories(${GTEST_INCLUDE_DIRS})
target_link_libraries(OPENGL ${GTEST_LIBRARY_DEBUG} ${GTEST_MAIN_LIBRARY_DEBUG})
