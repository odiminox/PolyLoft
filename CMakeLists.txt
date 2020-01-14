cmake_minimum_required(VERSION 2.6)
project (PolyLoftEngine)
 
set(CMAKE_BINARY_DIR ${CMAKE_SOURCE_DIR}/build)
 
set(EXECUTABLE_OUTPUT_PATH ${CMAKE_BINARY_DIR})
set(LIBRARY_OUTPUT_PATH ${CMAKE_BINARY_DIR})
 
set(PROJECT_SRC_DIR ${CMAKE_SOURCE_DIR}/src)
set(PROJECT_INCLUDE_DIR ${PROJECT_SOURCE_DIR}/include)
 
include_directories("${PROJECT_INCLUDE_DIR}")
include_directories("${PROJECT_SOURCE_DIR}")
include_directories("${CMAKE_SOURCE_DIR}/include")

# SUB COMPONENTS HERE
add_subdirectory(src/opengl)

set(PROJECT_LIBS
  OPENGL
)

add_executable(${PROJECT_NAME} ${PROJECT_SRC_DIR}/main.cpp)
target_link_libraries(${PROJECT_NAME} ${PROJECT_LIBS})
