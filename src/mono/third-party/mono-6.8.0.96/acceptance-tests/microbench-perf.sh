#! /bin/sh
r='/home/simon/dev/PolyLoft/src/mono/third-party/mono-6.8.0.96'
aotpattern="--aot="

# if this is an aot invoke
if [[ $@ =~ $aotpattern ]];
then
# just aot the code
echo "$r/runtime/mono-wrapper $@"
exec $r/runtime/mono-wrapper $@
else
# else run it under perf
echo "$MONO_PERF_BINARY record -o $r/acceptance-tests/perf.data -v -s -g -- $r/mono/mini/mono-sgen $@"
exec $MONO_PERF_BINARY record -o $r/acceptance-tests/perf.data -v -s -g $r/mono/mini/mono-sgen $@
fi


